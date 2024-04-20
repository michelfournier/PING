using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UIElements;

public class cpuOpponent : MonoBehaviour
{   
    public float moveSpeed;
    public Vector2 startingPosition = new Vector2(7.5f,0.0f);
    public float bottomBounds = -5.1f;
    public float topBounds = 5.02f;

    public GameObject ball;

    private Vector2 ballPos;

    private float previousBall = 0f;

    public LogicScript logic;

    AudioSource audioSound;

      
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = (Vector3)startingPosition;
        logic = GameObject.Find("LogicSystem").GetComponent<LogicScript>();
        audioSound = GetComponent<AudioSource>();        
    }

    // Update is called once per frame
    void Update()
    {

        moveSpeed = logic.p2Rate;
        Move();
        
    }

    //--------------------------- Methods -----------------------------
    public void Move()
    {

        ball = GameObject.FindGameObjectWithTag("ballz");//get the ball

        if (ball) // if there is a ball at all do the following
        {

            ballPos = ball.transform.position; //get the ball location

            if (ballPos.x >= 0) //cpu  medium = previousBall. harder is no if-statement here, easier is >= 0
            { 
            
                if (transform.localPosition.y > bottomBounds && ballPos.y < transform.localPosition.y) //if paddle is higher than botttom but higher than the ball
                {
                    transform.localPosition += new Vector3 (0, -moveSpeed * Time.deltaTime, 0); //will move down at set movespeed
                }

                if (transform.localPosition.y < topBounds && ballPos.y > transform.localPosition.y) //if paddle is lower than top but lower than the ball
                {
                    transform.localPosition += new Vector3 (0, moveSpeed * Time.deltaTime, 0); //will move up at set movespeed
                }
            }

            previousBall = ballPos.x; //record the ball's X position as the Next frame's previous X position
       
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSound.Play();             

    }        
}
