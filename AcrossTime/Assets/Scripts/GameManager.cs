using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public GameObject Map; // Reference to the parent object "Map"

    public GameObject Player1;
    public GameObject Player1Goal;

    public GameObject Player2;
    public GameObject Player2Goal;

    public Text player1Text;
    public Text player2Text;

    private int player1Score;
    private int player2Score;

    public bool IAGame; 

    public void Player1Scored()//Player on the right
    {
        player1Score++; //+1 point
        player1Text.text = player1Score.ToString();//Convert int to string and set the text
        ResetPosition();
        
    }

    public void Player2Scored()//Player on the Left
    {
        player2Score++; //+1 point
        player2Text.text = player2Score.ToString();//Convert int to string and set the text
        ResetPosition();
        ChangeColorOfField(Random.ColorHSV(0.0f, 1.0f, 0.0f, 1.0f, 0.3f, 1.0f)); // Change color of all child objects under 'map' to random color not dark
    }

    private void ResetPosition()
    {
        
        if (IAGame)
        {
            ball.GetComponent<Ball>().Reset();//Reset the ball
            Player2.GetComponent<Players>().Reset();//Reset the P2
        }
        else 
        {
            ball.GetComponent<Ball>().Reset();//Reset the ball
            Player1.GetComponent<Players>().Reset();//Reset the P1
            Player2.GetComponent<Players>().Reset();//Reset the P2
        }
    }

    private void ChangeColorOfField(Color newColor)
    {
        // Iterate through all child objects of 'map'
        foreach (Transform child in Map.transform)
        {
            // Check if the child has a SpriteRenderer component
            SpriteRenderer sr = child.GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.color = newColor; // Assign a random color
            }
        }
    }


}
