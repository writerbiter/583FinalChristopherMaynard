using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnInvisible : MonoBehaviour
{
    public Listen ListenScriptHere; 
    void Start()
    {
       GetComponent<BoxCollider>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        { 
            if(GetComponent<BoxCollider>().enabled == true)
            {
                GetComponent<BoxCollider>().enabled = false;
            }
            else { 
                GetComponent<BoxCollider>().enabled = true; 
            }
                }
        if (ListenScriptHere.targetInrange == true)
        {

        }
    }
}
