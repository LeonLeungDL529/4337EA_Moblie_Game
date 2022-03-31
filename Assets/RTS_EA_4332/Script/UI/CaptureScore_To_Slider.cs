using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureScore_To_Slider : MonoBehaviour
{
    [SerializeField] Capture_Score target;
    private void Update()
    {
        this.GetComponent<Slider>().value = target.captureScore / target.captureScoreMax;
    }
}
