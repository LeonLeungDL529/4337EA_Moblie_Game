using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
 {
    [SerializeField] float intervalForShoot = 100f;
    public GameObject shootingPoint;
    public GameObject checkingPoint;
    public GameObject bullet;
    public string enemyTag;
    public GameObject character;

    [SerializeField] private GameObject shootingSource;
    [SerializeField] private bool beginningShooting = false;
    [SerializeField] private LayerMask layerMask;
    private float nextForFire = 0f;
    
    private void Update()
    {
        if (beginningShooting && Time.time >= nextForFire)
        {
            nextForFire = Time.time + 5f / intervalForShoot;
            Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
            Instantiate(shootingSource, shootingPoint.transform.position, shootingPoint.transform.rotation);
            beginningShooting = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == enemyTag)
        {
            checkingPoint.transform.LookAt(other.transform);

            RaycastHit hit;
            Ray r = new Ray(checkingPoint.transform.position, checkingPoint.transform.forward);
            Physics.Raycast(r, out hit, this.GetComponent<SphereCollider>().radius, layerMask);
            //Debug.DrawLine(checkingPoint.transform.position, Vector3.forward, Color.red, this.GetComponent<SphereCollider>().radius, true);       
            if (hit.transform.tag == enemyTag)
            {
                character.transform.LookAt(other.transform);
                beginningShooting = true;
               // Debug.Log("this is Enemy\n" + "tag:" + hit.transform.tag.ToString() + " Name:" + hit.transform.name.ToString());
            }
                
        }       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == enemyTag)
        {
            nextForFire = 0f;
            checkingPoint.transform.LookAt(null);
            beginningShooting = false;

        }
    } 
}

