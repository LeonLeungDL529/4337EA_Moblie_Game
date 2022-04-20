using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew_Del : MonoBehaviour
{
    [SerializeField] private float delTime = 5;
    public bool destorypew;
    // Start is called before the first frame update
    private void Awake()
    {
        if (destorypew== true) 
        {
            GameObject.Destroy(this.gameObject, delTime); 
        }
        if (destorypew == true)
        {
            Invoke("hideBullet", 2.0f);
        }
    }

    void hideBullet()
    {
        gameObject.SetActive(false);
    }
}
