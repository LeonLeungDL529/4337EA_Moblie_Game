using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDel : MonoBehaviour
{
    [SerializeField]private float delTime = 2;
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject.Destroy(this.gameObject, delTime);
    }
}
