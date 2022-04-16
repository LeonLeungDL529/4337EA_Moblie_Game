using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Ray touchingRay;
    [SerializeField] LayerMask layer;
    [SerializeField] int teamNumber = 1;
    void Update()
    {
        if (Input.touchCount != 1) { return; }
        Touch touch = Input.touches[0];
        if(touch.phase == TouchPhase.Began) 
        {          
            Ray touchRay = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if(Physics.Raycast(touchRay,out hit,1000, layer))
            {
                if(hit.collider.gameObject.GetComponent<NavFollower>() !=null)
                {
                    hit.collider.gameObject.GetComponent<NavFollower>().SelectingChess();
                    Debug.Log("Working");
                }
                else if(hit.collider.gameObject.GetComponent<NavFollower>() == null)
                {
                    foreach (GameObject chess in GameObject.FindGameObjectsWithTag("Chess")) { chess.GetComponent<NavFollower>().isSelected = false; }
                }
            }
                
        }
        if (touch.phase == TouchPhase.Ended) 
        {
            Ray touchRay = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            Physics.Raycast(touchRay, out hit);
            foreach (GameObject chess in GameObject.FindGameObjectsWithTag("Chess"))
            {
                NavFollower navFollower = chess.GetComponent<NavFollower>();
                ChessManager chessManager = chess.GetComponentInParent<ChessManager>();
                if (navFollower.isSelected&&teamNumber == chessManager.chessTeamNumber)
                {
                    navFollower.ChessMove(hit.point);
                }
                navFollower.isSelected = false;
            }
        }



    }
}
