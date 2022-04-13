using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Con : MonoBehaviour
{
    bool moveALlowed;
    Vector3 touchPosWorld;
    private NavFollower NavFol;
    void Start()
    {
      

    }




    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
          //  if (touch.phase == TouchPhase.Began ){}

            
            

            touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

            //We now raycast with this information. If we have hit something we can process it.
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

            if (hitInformation.collider.CompareTag("chess"))
            {
                //We should have hit something with a 2D Physics collider!
                GameObject touchedObject = hitInformation.transform.gameObject;
                
            }
        }




    }
}
