using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew_Del : MonoBehaviour
{
    [SerializeField] private float delTime = 5;
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject.Destroy(this.gameObject, delTime);
    }
}
