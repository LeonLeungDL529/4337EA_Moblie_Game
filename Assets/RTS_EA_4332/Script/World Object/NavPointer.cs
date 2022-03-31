using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavPointer : MonoBehaviour
{
    [SerializeField] private Transform pointer;
    [SerializeField] private SelectableCharacter sc;
    [SerializeField] private Transform navPoint;
    private Identified id;
    public bool isAi = false;

    

    private void Awake()
    {

        pointer = GameObject.Find("Pointer").transform;
        id = GameObject.FindObjectOfType<Identified>();
        
    }
    private void Update()
    {
        if(sc.selected && Input.GetMouseButton(1)&&this.tag == id.identified)
        {
            navPoint.transform.position = pointer.position;
        }
        if (isAi)
        {
            navPoint.transform.position = new Vector3 (GameObject.Find("P1_Castle FBX").transform.position.x+20,0, GameObject.Find("P1_Castle FBX").transform.position.z);
        }
        
    }

}
