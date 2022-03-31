using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heath_To_Slider : MonoBehaviour
{
    [SerializeField] private Building_Health hp;   
    void Update()
    {
        this.GetComponent<Slider>().value = hp.health / hp.maxHealth;
    }
}
