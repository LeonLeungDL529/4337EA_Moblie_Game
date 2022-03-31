using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Health : MonoBehaviour
{
    public float health;
    public float maxHealth = 100f;
    public bool alive = true;
    
    private void Awake()
    {
        health = maxHealth;
    }
    private void Update()
    {
        if (health <= 0&&alive)
        {
            Death();
            alive = false; 
        }
    }
    private void Death()
    {
        GameObject.FindObjectOfType<Identified>().GoodGame(this.tag);
    }
    public void TakingDamage(float damage)
    {
        if (health > 0)
        {
            health -= damage;
        }
    }
}
