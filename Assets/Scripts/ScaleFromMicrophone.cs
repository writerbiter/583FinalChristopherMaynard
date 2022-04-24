using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{

    public Vector3 minScale;
    public Vector3 maxScale;
    public Vector3 jump;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;

    

    void Update()
    {
        //if (Input.GetKeyDown("space"))
        //{
        //    transform.position += jump * Time.deltaTime;
        //}

        
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;

        if (loudness < threshold)
            loudness = 0;


        //lerp value from minscale to maxscale


        //if (Input.GetKey("space"))
        //{
        //    transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);
        //}



        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);

        //Debug.Log(detector.GetLoudnessFromMicrophone());

    }
}
