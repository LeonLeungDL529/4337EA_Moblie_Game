using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heath_Bar : MonoBehaviour
{
    [SerializeField] private GameObject character;
    [SerializeField] private Slider healthBar;
    void Update()
    {
        this.transform.position = new Vector3(character.transform.position.x,this.transform.position.y,character.transform.position.z);
        healthBar.value = character.GetComponent<Health>().health /character.GetComponent<Health>().maxHealth;
    }
}
