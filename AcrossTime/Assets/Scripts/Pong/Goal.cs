using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public bool player1Goal;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)//When something collide with the object with this script
    {
        if (collision.CompareTag("Ball"))//If collide with ball
        { 
            if (player1Goal)
            {
                gameManager.GetComponent<GameManager>().Player1Scored();// 1 Point to P1
            }
            else
            {
                gameManager.GetComponent<GameManager>().Player2Scored();// 1 Point to P2
            }
        }

    }






}
