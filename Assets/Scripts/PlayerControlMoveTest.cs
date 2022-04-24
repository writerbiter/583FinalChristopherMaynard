using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlMoveTest : MonoBehaviour
{
    //no start function here, instead start script with reference to character controller
    public CharacterController controller;

    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        //we want to move around using WASD and arrowkeys; this is how we get horizontal and vertical inputs
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

    }
}
