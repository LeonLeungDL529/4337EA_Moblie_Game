using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Spawn_Soldier : MonoBehaviour
{
    [SerializeField]private Cost_Soldier GM;
    [SerializeField]private List<SpawnSoldier> ss;
    private float timeLimit = 10.0f;
    public float maxTime = 25.0f;
    public float minTime = 5;


    private void Update()
    {
        
        if(Time.time >= timeLimit)
        {
            timeLimit = Time.time + 5f;
            float rng = Random.Range(0, ss.Count);
            if(Mathf.Round(rng) == 0)
            {
                while (GM.cost > ss[0].neededCost)
                {
                    ss[0].SpawningUnit();
                    SetRandomTime();
                }
            }
            if (Mathf.Round(rng) == 1)
            {
                while (GM.cost > ss[1].neededCost)
                {
                    ss[1].SpawningUnit();
                    SetRandomTime();
                }
            }
            if (Mathf.Round(rng) == ss.Count)
            {
                
            }
        }
    }
    void SetRandomTime()
    {
        timeLimit = Random.Range(minTime, maxTime);
    }
}
