using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class TrueVision : MonoBehaviour
{
    public GameObject innerRing;
    public GameObject ghostsParticles;
    public GameObject Image;

    public float seeingCounter;
    public float counter;
    bool startCounter = false;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        
    }

    // Update is called once per frame

    private void Update()
    {
        
        if (startCounter == true)
        {
            counter += Time.deltaTime;
            if (counter >= seeingCounter)
            {
                Destroy(innerRing);
                Destroy(ghostsParticles);
                counter = seeingCounter;
            }
        }
    }


    /* private void OnTriggerExit(Collider other)
     {
         if (other.gameObject.CompareTag("Player"))
         {
             NoThereIsnt();
         }

     }*/


    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player") && Image.GetComponent<ColorSwitch>().goldilocks == true)
            {
            runCounter();
        }

        }
    void runCounter() { 
        startCounter = true;
       
    }    
        /* public void NoThereIsnt()
          {
              counter = 0;

              }*/
    
}

