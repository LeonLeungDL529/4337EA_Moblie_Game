using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ChessManager : MonoBehaviour
{
    public float chessMaxHeath = 100f, chessSpeed = 3.5f, chessDamage = 30f, shootingSpeed = 10f;
    public int chessTeamNumber = 1;
    [SerializeField] Slider hpSlider;
    [SerializeField] Text hpTxt;
    [SerializeField] ChessHealth chessHealth;
    private void Awake()
    {
        GetComponentInChildren<NavMeshAgent>().speed = chessSpeed;
    }

    private void Update()
    {
        hpSlider.value = chessHealth.chessHealth/chessMaxHeath;
        hpTxt.text = "Hp: " + chessHealth.chessHealth;
    }

}
