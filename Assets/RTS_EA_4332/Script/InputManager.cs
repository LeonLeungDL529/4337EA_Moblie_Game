using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Ray touchingRay;
    void Update()
    {
        if (Input.touchCount != 1) { return; }
        Touch touch = Input.touches[0];
        if(touch.phase == TouchPhase.Began) 
        {          
            Ray touchRay = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if(Physics.Raycast(touchRay,out hit))
            {
                if(hit.collider.gameObject.GetComponent<NavFollower>() !=null)
                {
                    hit.collider.gameObject.GetComponent<NavFollower>().SelectingChess();
                    Debug.Log("success");
                }
            }
                
        }
        if (touch.phase == TouchPhase.Ended)
        {

        }

    }
}
