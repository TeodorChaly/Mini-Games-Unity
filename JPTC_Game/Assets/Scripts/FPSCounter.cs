using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI textFps;
    int fpsCoutner = 0;
    float mTimeCounter = 0.0f;
    float LastFrameRate = 0.0f;
    public float refreshtime = 0.5f;
    const string format = "FPS {0}";
    void Update()
    {
        if (mTimeCounter < refreshtime){
            mTimeCounter += Time.deltaTime;
            fpsCoutner++;
        }
        else {
            LastFrameRate = (float)fpsCoutner / mTimeCounter;
            fpsCoutner= 0;
            mTimeCounter = 0.0f;

        }
        textFps.text = string.Format(format, LastFrameRate);
    }
}
