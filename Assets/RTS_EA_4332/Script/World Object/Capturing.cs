using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capturing : MonoBehaviour
{
    public bool p1Capture=false, p2Capture=false;
    public Capture_Score p1;
    public float timeRate = 2, nextCount = 0;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player_1")
        {
            p1Capture = true;
        }
        if(other.tag == "Player_2")
        {
            p2Capture = true;
        }
    }
    private void Update()
    {
        if (Time.time>nextCount) {
            nextCount = Time.time + timeRate;
            if (p2Capture && !p1Capture)
            {
                p2Capture = false;
                p1Capture = false;
                p1.StartingCapturered();

            }
            if (p1Capture && !p2Capture)
            {
                p2Capture = false;
                p1Capture = false;
                p1.StartingCaptureredblue();
            } }
        else if (p1Capture && p2Capture)
        {
            p2Capture = false;
            p1Capture = false;
        }
    }
}
