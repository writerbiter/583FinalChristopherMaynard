using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Listen : MonoBehaviour
{
    public Transform ghostGoesHere;
    NavMeshAgent agent;
    public GameObject seerGoesHere;
    public ColorSwitch colorswitch;
    
    public bool targetInrange;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
       
    }

    private void Update()
    {
        if (targetInrange == true && colorswitch.goldilocks == true)
        {
            agent.SetDestination(ghostGoesHere.position);
            ;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //make sure the collision occurs with the player
        if (other.gameObject.CompareTag("Player") && this.enabled == true)
        {
            print("Ghost is in listening range.");
            engage();
        }
            
        //add condition here about the mic input level and thresholds being relevant. 

       
    }

    void OnTriggerExit(Collider other)
    {
        //make sure the collision occurs with the player
        if (other.gameObject.CompareTag("Player"))
        {
            print("Ghost has left listening range.");
            disengage();
        }
            

        
    }
    public void engage()
    {
        Debug.Log("engage called");
        targetInrange = true;
    }
    public void disengage()
    {
        Debug.Log("disengage called");
        targetInrange = false;
        seerGoesHere.GetComponent<Patrol>().GotoNextPoint();
        
    }
}
