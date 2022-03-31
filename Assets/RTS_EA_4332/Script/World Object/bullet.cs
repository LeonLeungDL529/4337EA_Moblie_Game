using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5f,damage = 5f;
    public string enemyTag;
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);
        Destroy(gameObject, 1);      
    }

    private void OnTriggerEnter(Collider other)
    {        
        if(other.tag == "Barrier")
        {
            Destroy(this.gameObject);
        }
        if(other.tag == enemyTag)
        {
            Destroy(this.gameObject);
            if (other.GetComponent<Health>() != null) { other.GetComponent<Health>().TakingDamage(damage); }
            if (other.GetComponent<Building_Health>() != null) { other.GetComponent<Building_Health>().TakingDamage(damage); }

        }
    }
}
