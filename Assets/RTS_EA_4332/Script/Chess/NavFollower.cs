using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavFollower : MonoBehaviour
{
    [SerializeField] GameObject targetForFollow;
    private NavMeshAgent nav;
    public bool isSelected;
    [SerializeField] GameObject selectedRing;
    Animator chessMoveSet;
   public ChessHealth TheCH;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        chessMoveSet = this.GetComponent<Animator>();
        TheCH = this.GetComponent<ChessHealth>();
        targetForFollow.transform.position = transform.position;
    }
    void Update()
    {
        
        
        selectedRing.SetActive(isSelected);
        if (this.transform.position.x == targetForFollow.transform.position.x&& this.transform.position.z == targetForFollow.transform.position.z) { targetForFollow.SetActive(false); }
        else if (targetForFollow.activeSelf) { nav.destination = targetForFollow.transform.position; }
        if (TheCH.chessHealth <= 0.0f)
        {
            chessMoveSet.SetBool("Dead", true);
        }
        
    }

    public void ChessMove(Vector3 _Position) 
    {
        targetForFollow.SetActive(true);
        chessMoveSet.SetBool("Walk",true);
        targetForFollow.transform.position = _Position;
    }

    public void SelectingChess()
    {
        isSelected = !isSelected;
    }
}
