using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM1 : MonoBehaviour
{
    public GameObject blueBoss, redBoss;
    public GameObject wincon, losecon, PanelBtn;
  



    // Update is called once per frame
    void Update()
    {
        if (blueBoss ==null)
        {
            losecon.SetActive(true);
            PanelBtn.SetActive(true);
        }
        if (redBoss == null)
        {
            wincon.SetActive(true);
            PanelBtn.SetActive(true);
        }
    }
}
