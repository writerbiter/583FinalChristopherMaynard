using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol : MonoBehaviour
{

   
    public Transform[] points;//Filled using 'empty' GameObjects as elements in the inspector. 
    private int destPoint = 0;
    private NavMeshAgent agent;
    GameObject other;

    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;
        GotoNextPoint();
    }


    public void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;
        Debug.Log(points[destPoint].position);

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;//This would be the line I want to change to make random.
    }


    void Update()
    {
       
        // Choose the next destination point when the agent gets
        // close to the current one.
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
        
      
    }
}