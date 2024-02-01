
using UnityEngine;
using Unity.Netcode;

// this script saves us time instead of manually having to start ourselves everytime
// now we can attach each method to its own button
public class StartNetwork : MonoBehaviour
{

    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
    }

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
    }

}
