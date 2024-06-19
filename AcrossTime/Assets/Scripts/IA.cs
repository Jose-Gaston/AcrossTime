using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float speed = 3; // Speed at which the AI moves
    public GameObject ball; // Reference to the ball game object

    private Vector2 ballPos; // To store the position of the ball


    void Update()
    {
        Move(); // Call the Move method to update the AI's position
    }


    void Move()
    {
        ballPos = ball.transform.position; // Get the current position of the ball

        // If AI is above the ball, move downwards
        if (transform.position.y > ballPos.y)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        // If AI is below the ball, move upwards
        if (transform.position.y < ballPos.y)
        {
            transform.position += new Vector3(0, +speed * Time.deltaTime);
        }

    }




}
