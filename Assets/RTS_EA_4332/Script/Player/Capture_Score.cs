using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Photon.Pun;

public class Capture_Score : MonoBehaviour
{
    public float captureScoreMax=250, captureScore;
    public GameObject Losescreen;
    public Text word;
    public static float TimeScale;

  
      
        private void Start()
    {
        //captureScore = captureScoreMax;
        Time.timeScale = TimeScale;
        Losescreen.SetActive(false);
        captureScore = captureScoreMax / 2;
    }
    
    public void StartingCapturered()
    {
        captureScore -= 10;
    }
    public void StartingCaptureredblue()
    {
        captureScore += 10;  
    }
    private void Update()
    {

        if (captureScore>= captureScoreMax)
        {
            Time.timeScale = 0.0f;
            Losescreen.SetActive(true);
            Losescreen.GetComponent<Image>().color= Color.blue;
            word.text = "The blue side role the wave.";

        }
        if(captureScore <= (captureScoreMax- captureScoreMax))
        {
            Time.timeScale = 0.0f;
            Losescreen.SetActive(true);
            Losescreen.GetComponent<Image>().color =    Color.red;
            word.text = "Glory to the heroes of the Patriotic War! Glory to the Red Army!";
        }
        else
        {
            Time.timeScale = 1.0f;
        }



    }
}
