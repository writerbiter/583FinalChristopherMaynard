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
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Image.GetComponent<ColorSwitch>().goldilocks == true)
        {
            IsSomeoneThere();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NoThereIsnt();
        }
        
    }

    public void IsSomeoneThere()
    {
        counter +=Time.deltaTime;
        if (counter >= seeingCounter)
        {
            Destroy(innerRing);
            Destroy(ghostsParticles);
        }
    }
   public void NoThereIsnt()
    {
        counter = 0;
    }
}
