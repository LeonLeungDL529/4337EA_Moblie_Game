using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessHealth : MonoBehaviour
{
    public int chessTeamNumber;
    public float chessHealth;
    [SerializeField] private ChessManager chessManager;

    private void Start()
    {
        chessHealth = chessManager.chessMaxHeath;
        chessTeamNumber = chessManager.chessTeamNumber;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Bullet")
        {
            Bullet bullet = other.gameObject.GetComponent<Bullet>();
            if (bullet.chessTeamNumber != chessTeamNumber)
            {
                chessHealth -= bullet.damage;
                Destroy(bullet.gameObject);
            }
        }
    }
    private void Update()
    {
        if(chessHealth <= 0)
        {
           
            Destroy(transform.parent.gameObject); 
        }
    }
}
