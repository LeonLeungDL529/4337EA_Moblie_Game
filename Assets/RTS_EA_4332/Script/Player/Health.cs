using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth = 100f;
    [SerializeField] private GameObject character;
    private SelectManager selectManager;

    [SerializeField] GameObject deathSource;
    private void Awake()
    {
        selectManager = GameObject.Find("Selecter").GetComponent<SelectManager>();
        health = maxHealth;
    }
    private void Update()
    {
        if(health <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        Instantiate(deathSource);
        Destroy(character);
        selectManager.SelectChecking();
    }
    public void TakingDamage(float damage)
    {
        if(health > 0)
        {
            health -= damage;
        }
    }
}
