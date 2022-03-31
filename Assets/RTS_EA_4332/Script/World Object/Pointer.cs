using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class Pointer : MonoBehaviour
{
    public GameObject pointer;
    Vector3 worldPosition;
    [SerializeField] Camera maincam;
    public static Vector3 mousePos;
    SelectableCharacter selected;
     public LayerMask G_layer;
    //LayerMask.NameToLayer

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        if ( Input.GetMouseButtonDown(1))
        {
            // Pointer.transform.position;



            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            RaycastHit H;
         
            int Groundonly =    ((0 << 17) |(0<<5)| (1 << 19));
            if (Physics.Raycast(ray, out H, Groundonly, G_layer))
                {
                mousePos = transform.position = H.point;
                }


        }
    }
}
