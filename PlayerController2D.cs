using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    //Declaring all needed variables
    public float jump_scalar;
    public float movement_scalar;
    public float maxspeed;
    private Rigidbody2D rb;

    //Get RigidBody2D component
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    //Creating movement
    void FixedUpdate()
    {
        //Movement on X-axis
        float x_movement = Input.GetAxis("Horizontal");
        if (rb.velocity.magnitude < maxspeed)
        {
            Vector2 movement = new Vector2(x_movement,0);
            rb.AddForce(movement_scalar * movement);
        }
        //Jumping or movement on Y-axis
        if (Input.GetButtonDown("Jump"))
        {
            Vector2 jump_force = new Vector2(0,jump_scalar);
            rb.AddForce(jump_force);
        }
        
    }

}
