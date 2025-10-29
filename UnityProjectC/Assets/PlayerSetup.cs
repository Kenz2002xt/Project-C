using Fusion;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public GameObject hostPlayer;
    public GameObject clientPlayer;

    
    public void Start()
    {
        NetworkRunner runner =  FindAnyObjectByType<NetworkRunner>();

        if (runner.IsServer)
        {
            hostPlayer.SetActive(true);
            clientPlayer.SetActive(false);
        }
        else
        {
            hostPlayer.SetActive(false);
            clientPlayer.SetActive(true);
        }
    }
}
