using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject Player1;
    public GameObject Player1Goal;

    public GameObject Player2;
    public GameObject Player2Goal;

    public Text player1Text;
    public Text player2Text;

    private int player1Score;
    private int player2Score;

    public void Player1Scored()
    {
        player1Score++; //+1 point
        player1Text.text = player1Score.ToString();//Convert int to string and set the text
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++; //+1 point
        player2Text.text = player2Score.ToString();//Convert int to string and set the text
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();//Reset the ball
        Player1.GetComponent<Players>().Reset();//Reset the P1
        Player2.GetComponent<Players>().Reset();//Reset the P2
    }




}
