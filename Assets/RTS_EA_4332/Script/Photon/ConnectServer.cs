using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectServer : MonoBehaviourPunCallbacks
{
    //public string SceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("phase1");
        
    }

    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("phase2");
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Why don't charge scene");

    }


}
