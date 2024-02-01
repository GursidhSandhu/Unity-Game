using Unity.Netcode;
using UnityEngine;
using System.Collections.Generic;

public class PlayerLength : NetworkBehaviour
{
    // the added on body part when length increases
       // [SerializeField] private GameObject tail;

        // declare a new network variable for players length
        // this also manages who can read and write this length
       // public NetworkVariable<ushort> length = new(1,NetworkVariableReadPermission.Everyone,
       //     NetworkVariableWritePermission.Server);

       // private List<GameObject> tails;
       // private Transform lastTail;
       // private Collider2D collider;

       // public override void OnNetworkSpawn()
       // {
        //    base.OnNetworkSpawn();
        //    tails = new List<GameObject>();
        //    lastTail = transform;
        //    collider = GetComponent<Collider2D>();
        //}

        // this is just so we can call it directly from inspector to test it
        //[ContextMenu("Add Length")]
        //private void AddLength()
        //{
        //    length.Value += 1;
        //    InstantiateTail();
       // }

        //private void InstantiateTail()
        //{
            // local GameObject, not in network yet
          //  GameObject tailObject = InstantiateTail(tail, transform.position, Quaternion.identity);

            // this is to make sure the earlier tails appear on top of later added tails ( can flip if wanted )
          //  tailObject.GetComponent<SpriteRenderer>().sortingOrder = -length.Value;

            // try to see if this object can get a reference to any tail
          //  if(tailObject.TryGetComponent(out Tail tail)){
                // update tail to body, keep track of latest tail, and avoid any collision between tails
          //      tail.networkedOwner = transform;
          //      tail.followTransform = lastTail;
         //       lastTail = tailObject.transform;
         //       Physics2D.IgnoreCollision(tailObject.GetComponent<Collider2D>(), collider);
         //   }
         //       tails.Add(tail);
        //}

}
