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

      
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = (Vector3)startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {

       if (!ball) 
       {
        ball = GameObject.FindGameObjectWithTag("ballz");//bob
       }

       //Debug.Log(ball.GetComponent<ballScript>().myRigidBody.velocity.ToString());  only gets (0.00, 0.00)

        //if (ball.GetComponent<ballScript>().myRigidBody.velocity == Vector2.right)
       //{
            ballPos = ball.transform.localPosition; //get ball location
            Debug.Log(ballPos.ToString()); //(-0.04, -0.05) only. as if it didn't change
            if (transform.localPosition.y > bottomBounds && ballPos.y < transform.localPosition.y) //if paddle is higher than botttom but higher than the ball
            {
                transform.localPosition += new Vector3 (0, -moveSpeed * Time.deltaTime, 0); //will move down at set movespeed
            }

            if (transform.localPosition.y < topBounds && ballPos.y > transform.localPosition.y) //if paddle is lower than top but lower than the ball
            {
                transform.localPosition += new Vector3 (0, moveSpeed * Time.deltaTime, 0); //will move up at set movespeed
            }
       // }
    }
}
