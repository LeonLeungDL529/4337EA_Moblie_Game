using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateRoom : MonoBehaviourPunCallbacks
{
    public InputField create, join, restart;
    public void Create()
    {
        PhotonNetwork.CreateRoom(create.text);
        
        PlayerPrefs.SetString("playerID", "Player_1");
    }
    public void Join()
    {
        PhotonNetwork.JoinRoom(join.text);

        PlayerPrefs.SetString("playerID", "Player_2");
    }
    public void quitapp()
    {
       
            Application.Quit();
     
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
}