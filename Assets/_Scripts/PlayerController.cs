using System.Collections;
using Unity.Netcode;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    // don't let this speed get changed by anything else
    [SerializeField] private float speed = 3f;

    private Camera mainCamera;
    private Vector3 mouseInput = Vector3.zero;

    // this function is just so we can reference main camera easily
    // don't have to keep calling it over and over again
    private void Initialize()
    {
        mainCamera = Camera.main;
    }

    // when the player is spawned, initialize it
    // doing this here and not onStart, because we dynamically spawn players
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();
        Initialize();
    }

    private void Update()
    {

        // this makes sure that we can only move the character on
        // whatever editor we are currently on
        if (!IsOwner || !Application.isFocused) return;

        // this is all for the movement

        mouseInput.x = Input.mousePosition.x;
        mouseInput.y = Input.mousePosition.y;
        // since our game is 2d, we don't use the z position
        mouseInput.z = mainCamera.nearClipPlane;

        Vector3 mouseWorldCoord = mainCamera.ScreenToWorldPoint(mouseInput);
        mouseWorldCoord.z = 0f;

        transform.position = Vector3.MoveTowards(transform.position,
            mouseWorldCoord, Time.deltaTime * speed);

        // this is all for rotation towards our mouse
        // only want to rotate if we moved
        if(mouseWorldCoord != transform.position)
        {
            // find the direction we need to move in
            Vector3 target = mouseWorldCoord - transform.position;
            target.z = 0f;

            // move to new target position
            transform.up = target;
        }



    }
}
