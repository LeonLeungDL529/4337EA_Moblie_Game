using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
 {
    public float intervalForShoot = 10f;
    public GameObject shootingPoint;
    public GameObject checkingPoint;
    public GameObject bullet;
    [SerializeField] private GameObject shootingSource;
    public int chessTeamNumber;
    public GameObject character;
    [SerializeField]AudioSource bulletAudio;
    [SerializeField] private ChessManager chessManager;
    private Bullet bulletManager;
    //List<GameObject> bulletList;
    List<GameObject> pewtList;
    //[SerializeField] private GameObject shootingSource;
    [SerializeField] public bool beginningShooting = false;
    [SerializeField] private LayerMask layerMask;
    private float nextForFire = 0f;

    private void Start()
    {
        chessTeamNumber = chessManager.chessTeamNumber;
        bulletManager = bullet.GetComponent<Bullet>();
        /* bulletList = new List<GameObject>();
          for (int i = 0; i < 2; i++)
          {
              GameObject objBullet = (GameObject)Instantiate(bullet);
              objBullet.SetActive(false);
              bulletList.Add(objBullet);
          } */
        pewtList = new List<GameObject>();
        for (int i = 0; i < 2; i++)
        {
            GameObject objPew = (GameObject)Instantiate(shootingSource);
            objPew.SetActive(false);
            pewtList.Add(objPew);
        }
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
            for (int i = 0; i < pewtList.Count; i++)
            {
                if (!pewtList[i].activeInHierarchy)

                {
                    pewtList[i].transform.position = transform.position;
                    pewtList[i].transform.rotation = transform.rotation;
                    pewtList[i].SetActive(true);
                    
                    break;
                }
            }
            Instantiate(shootingSource, shootingPoint.transform.position, shootingPoint.transform.rotation);
            //Instantiate(shootingSource, shootingPoint.transform.position, shootingPoint.transform.rotation);
            beginningShooting = false;
        }
        if (this.gameObject==null)
        {
            for (int i = 2; i > 0; i--)
            {
                Destroy(pewtList[i]);
            }
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
           
                if (other.GetComponent<ChessHealth>().chessTeamNumber != this.chessTeamNumber)
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

