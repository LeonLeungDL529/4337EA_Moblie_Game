using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
 {
    public float intervalForShoot = 10f;
    public GameObject shootingPoint;
    public GameObject checkingPoint;
    public GameObject bullet;
    public int chessTeamNumber;
    public GameObject character;
    [SerializeField] private ChessManager chessManager;
    private Bullet bulletManager;

    //[SerializeField] private GameObject shootingSource;
    [SerializeField] public bool beginningShooting = false;
    [SerializeField] private LayerMask layerMask;
    private float nextForFire = 0f;

    private void Start()
    {
        chessTeamNumber = chessManager.chessTeamNumber;
        bulletManager = bullet.GetComponent<Bullet>();
        intervalForShoot = chessManager.shootingSpeed;
    }
    private void Update()
    {
        if (beginningShooting && Time.time >= nextForFire)
        {
            nextForFire = Time.time + 5f / intervalForShoot;
            bulletManager.damage = chessManager.chessDamage;
            bulletManager.chessTeamNumber = chessTeamNumber;
            Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
           //Instantiate(shootingSource, shootingPoint.transform.position, shootingPoint.transform.rotation);
            beginningShooting = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {    if(other.tag == "Chess") {
            if (other.GetComponent<ChessHealth>().chessTeamNumber != this.chessTeamNumber)
            {
                checkingPoint.transform.LookAt(other.transform);
                RaycastHit hit;
                Ray r = new Ray(checkingPoint.transform.position, checkingPoint.transform.forward);
                Physics.Raycast(r, out hit, this.GetComponent<SphereCollider>().radius, layerMask);

                if (hit.collider.GetComponent<ChessHealth>().chessTeamNumber != this.chessTeamNumber)
                {
                    character.transform.LookAt(other.transform);
                    beginningShooting = true;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Chess")
        {
            if (other.GetComponent<ChessHealth>().chessTeamNumber != this.chessTeamNumber)
            {
                nextForFire = 0f;
                checkingPoint.transform.LookAt(null);
                beginningShooting = false;

            }
        }
    } 
}

