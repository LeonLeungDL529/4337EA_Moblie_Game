using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavFollower : MonoBehaviour
{
    [SerializeField] GameObject targetForFollow;
    private NavMeshAgent nav;
    [SerializeField]private bool isSelected;
    [SerializeField] GameObject selectedRing;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        targetForFollow.transform.position = transform.position;
    }
    void Update()
    {
        selectedRing.SetActive(isSelected);
        if (this.transform.position.x == targetForFollow.transform.position.x&& this.transform.position.z == targetForFollow.transform.position.z) { targetForFollow.SetActive(false); }
        else if (targetForFollow.activeSelf) { nav.destination = targetForFollow.transform.position; }
    }

    public void ChessMove(Vector3 _Position) 
    {
        targetForFollow.SetActive(true);
        targetForFollow.transform.position = _Position;        
    }

    public void SelectingChess()
    {
        isSelected = !isSelected;
    }
}
