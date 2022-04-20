using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavFollower : MonoBehaviour
{
    [SerializeField] GameObject targetForFollow;
    private NavMeshAgent nav;
    public bool isSelected;
    [SerializeField] GameObject selectedRing;
    Animator chessMoveSet;
   public ChessHealth TheCH;
    public Shooting shoot;
    public AudioClip arrr;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        chessMoveSet = this.GetComponent<Animator>();
        TheCH = this.GetComponent<ChessHealth>();
        
        targetForFollow.transform.position = transform.position;
    }
    void Update()
    {
        AudioSource aud = GetComponent<AudioSource>();
       

        selectedRing.SetActive(isSelected);
        if (this.transform.position.x == targetForFollow.transform.position.x&& this.transform.position.z == targetForFollow.transform.position.z) 
        { targetForFollow.SetActive(false); chessMoveSet.SetBool("Idle", true); chessMoveSet.SetBool("Walk", false); chessMoveSet.SetFloat("Run_Null", 0); }
        else if (targetForFollow.activeSelf)
        { nav.destination = targetForFollow.transform.position; }


        if (TheCH.chessHealth <= 0.0f)
        {
            
            aud.PlayOneShot(arrr);   
           
            chessMoveSet.SetBool("Dead", true);
                
                Destroy(transform.parent.gameObject, 2.5f);
         


        }
        if (shoot.beginningShooting== true)
        {
           
            chessMoveSet.SetBool("Shoot",true);
        }
        else
        {
            chessMoveSet.SetBool("Shoot", false);
        }


    }

    public void ChessMove(Vector3 _Position) 
    {
        targetForFollow.SetActive(true);
        chessMoveSet.SetBool("Walk", true); 
        chessMoveSet.SetBool("Idle", true);
        chessMoveSet.SetFloat("Run_Null",1);
        targetForFollow.transform.position = _Position;
    }

    public void SelectingChess()
    {
        isSelected = !isSelected;
    }
}
