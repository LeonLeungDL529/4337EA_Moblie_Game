using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cost_To_Text : MonoBehaviour
{
    [SerializeField] public Cost_Soldier cost_Soldier;
    // Update is called once per frame
    void Update()
    {
        if (cost_Soldier.cost < 10) { this.GetComponent<Text>().text = " MenPower : 00" + cost_Soldier.cost; }
        if (cost_Soldier.cost >= 10&&cost_Soldier.cost<100) { this.GetComponent<Text>().text = "MenPower : 0" + cost_Soldier.cost; }
        if (cost_Soldier.cost >= 100) { this.GetComponent<Text>().text = "MenPower : " + cost_Soldier.cost; }
    }
}
