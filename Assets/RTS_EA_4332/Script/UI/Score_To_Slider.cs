using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_To_Slider : MonoBehaviour
{
    [SerializeField] private Capture_Score cs;
    private void Update()
    {
        this.GetComponent<Slider>().value = cs.captureScore / cs.captureScoreMax;
    }
}
