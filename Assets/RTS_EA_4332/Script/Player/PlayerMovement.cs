using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public GameObject playerPointerForMove;
    private void Awake(){navMeshAgent = GetComponent<NavMeshAgent>();}
    void Update()
    {
        navMeshAgent.destination = playerPointerForMove.transform.position;
    }
}
