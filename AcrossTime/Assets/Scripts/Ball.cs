using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 7;
    public Rigidbody2D rb;
    private Vector2 starPos;


    void Start()
    {
        transform.position = starPos;//Set the starting position to the ball initial position
        Launch();//Inititate the Launch
    }
    public void Reset()
    {
        transform.position = starPos; //Move the ball to the init
        rb.velocity = Vector2.zero; //Set vel. to 0
        Launch(); //Lauch the ball
    }

    public void Launch () 
    {
        //no ve que wapo el juego

        float x = Random.Range(0,2) == 0 ? -1 : 1; // X Random direction of the Ball at the beggining, if its 0 will be -1, if not 1
        float y = Random.Range(0,2) == 0 ? -1 : 1; // Y Random direction of the Ball at the beggining, if its 0 will be -1, if not 1

        rb.velocity = new Vector2(speed * x, speed * y); // Set the velocity of the ball
    }
}
