using Photon.Pun;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class ConnectPun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.GameVersion = "0.0.1";
        PhotonNetwork.ConnectUsingSettings();
    }

    void Update()
    {
        
    }
}
