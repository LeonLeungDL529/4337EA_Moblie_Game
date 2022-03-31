using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost_To_Slider : MonoBehaviour
{
    [SerializeField] public Cost_Soldier cost_Soldier;
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Slider>().value = (float)cost_Soldier.cost / (float)cost_Soldier.maxCost;
    }
}
