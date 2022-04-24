using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitch : MonoBehaviour
{
    [SerializeField] Image lightChange;
    Color yellow = new Color(1, 1, 0, 1);
    Color red = new Color(1, 0, 0, 1);
    Color green = new Color(0, 1, 0, 1);

    public AudioLoudnessDetection detector;
    public float loudnessSensibility;

    public float thresholdFloor;
    public float thresholdLow;
    public float thresholdHigh;
    public bool goldilocks;


    // Start is called before the first frame update
    void Start()
    {
        //lightChange.color;
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;


        if (loudness < thresholdFloor)
        {
            lightChange.color = Color.white;
            goldilocks = false;

        }

        if (loudness >= thresholdFloor && loudness < thresholdLow)
        {
            lightChange.color = Color.yellow;
            goldilocks = false;

        }

        if (loudness >= thresholdLow && loudness < thresholdHigh)
        {
            lightChange.color = Color.green;
            goldilocks = true;
        }

        if (loudness >= thresholdHigh)
        {
            lightChange.color = Color.red;
            goldilocks = false;
        }






        //if (Input.GetKey("space"))
        //{
        //    if (loudness < thresholdFloor)
        //    {
        //        lightChange.color = Color.white;
        //    }

        //    if (loudness >= thresholdFloor && loudness < thresholdLow)
        //    {
        //        lightChange.color = Color.yellow;
        //    }

        //    if (loudness >= thresholdLow && loudness < thresholdHigh)
        //    {
        //        lightChange.color = Color.green;
        //    }

        //    if (loudness >= thresholdHigh)
        //    {
        //        lightChange.color = Color.red;
        //    }
        //}

    }
}

//Color colorName = new Color(x, y ,z, a);