using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public bool player1; // Determines if this is player 1 or player 2
    public float speed = 3; // Speed of the player's movement
    public Rigidbody2D rb;

    private float move; // Stores the player's input for movement
    private Vector2 startPos; // Stores the starting position of the player



    void Start()
    {
        startPos = transform.position; // Set the starting position to the player's initial position
    }

    void Update()
    {
        if (player1)
        {
            move = Input.GetAxisRaw("Vertical"); // Get the vertical input for player 1
        }
        else
        {
            move = Input.GetAxisRaw("Vertical2"); // Get the vertical input for player 2
        }
        rb.velocity = new Vector2(rb.velocity.x, move*speed); // Set the velocity of the Rigidbody2D based on the input and speed
    }

    public void Reset () 
    {
        rb.velocity = Vector2.zero;   
        transform.position = startPos; //Reset to the start position


    }
}
