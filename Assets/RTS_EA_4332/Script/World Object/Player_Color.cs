using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Color : MonoBehaviour
{
    [SerializeField] private Color32 Thecolor;
    private void Update()
    {
        GetComponent<Renderer>().material.color = Thecolor;
    }
}
