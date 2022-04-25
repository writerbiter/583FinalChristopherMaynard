using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Green : MonoBehaviour
{

    [SerializeField] Image lightChange;
    //Color yellow = new Color(1, 1, 0, 1);
    //Color red = new Color(1, 0, 0, 1);
    //Color green = new Color(0, 1, 0, 1);

    public AudioLoudnessDetection detector;
    public ColorSwitch colorSwitch;


    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * colorSwitch.loudnessSensibility;


        if (loudness < colorSwitch.thresholdLow)
        {
            lightChange.color = Color.white;

        }

        if (loudness >= colorSwitch.thresholdLow)
        {
            lightChange.color = Color.green;
        }

    }
}