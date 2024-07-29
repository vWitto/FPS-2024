using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager instance;
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(); // conecta ao servidor Photon usando configurações definidas
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connection Successful");

        MenuManager.instance.Connected();
    }

    // Update is called once per frame
    
}
