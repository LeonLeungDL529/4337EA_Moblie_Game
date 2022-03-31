using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Identified : MonoBehaviour
{
    public string identified;
    [SerializeField] GameObject p1UI, p2UI; 

    public void GoodGame(string whoLose)
    {
        if (whoLose == "Player_1") { print("Player_1 Move"); }
        if (whoLose == "Player_2") { print("Player_2 Move"); }
    }

    private void Awake()
    {
        identified = PlayerPrefs.GetString("playerID");
        if (identified == "Player_1")
        {
            p1UI.SetActive(true); 
        }
        if (identified == "Player_2")
        {
            p2UI.SetActive(true); 
        }
    }
}
