using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpawnSoldier : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject soldier;
    [SerializeField] private float minX, maxX, minZ, maxZ;
    [SerializeField]private Cost_Soldier Cost_Soldier;
    public int neededCost = 50;
    public SelectManager selectManager;
    public GameObject ChessDetail;



    private void Awake()
    {
        selectManager = GameObject.Find("Selecter").GetComponent<SelectManager>();
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        ChessDetail.SetActive(true);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {

        ChessDetail.SetActive(false);
    }

    public void SpawningUnit()
    {
        if(Cost_Soldier.cost >= neededCost)
        {
            Cost_Soldier.cost -= neededCost;
            PhotonNetwork.Instantiate(soldier.name, new Vector3(Random.Range(minX, maxX), 1, Random.Range(minZ, maxZ)), Quaternion.identity);
            selectManager.SelectChecking();
        }
        else
        {
            Debug.Log("Not enough cost");
        }
    }
}
