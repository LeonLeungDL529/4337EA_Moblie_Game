using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cost_Soldier : MonoBehaviour
{
    [SerializeField] float nextForCost = 0;
    public int cost = 0, maxCost = 500;
    [SerializeField] private float interval = 10f;
    [SerializeField] private int costRare = 25;
    private void Update()
    {
        if (Time.time >=nextForCost && cost < maxCost)
        {
            nextForCost = Time.time + 5f/interval;
            cost += costRare;            
        }            
    }
}
