using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class IA : MonoBehaviour
{
    public float speed = 3; // Speed at which the AI moves
    public GameObject ball; // Reference to the ball game object
    public GameObject gameManager; //Reference to the object GameManager
    public GameObject Player1; // Reference to the object Player1 (IA)

    private Vector2 ballPos; // To store the position of the ball


    void Update()
    {
        Move(); // Call the Move method to update the AI's position

        int player2Score = gameManager.GetComponent<GameManager>().player2Score;// Acces to the Player Score
        if (player2Score >= 5)//If score is 5 or more (Ending of this game)
        {
            Collider2D player1Collider = Player1.GetComponent<Collider2D>();//Acces to the player 1 (IA) collider
            player1Collider.isTrigger = true; //Setting it to true 
        }
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
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            int player2Score = gameManager.GetComponent<GameManager>().player2Score;// Acces to the Player Score

            Debug.Log("Player 2 Score: " + player2Score);//Express via console the score of the player

            if (player2Score >= 5)//If score is 5 or more (Ending of this game)
            { 
                Debug.Log("Moving Player1 to the right");
                Player1.transform.position += new Vector3(0.3f, 0f, 0f);//Move it to the right
            }
        }
    }
}
