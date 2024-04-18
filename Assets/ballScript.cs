using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ballScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float ballSpeed; //make selection of speed at the splash screen so it that value can modified both the original and clones

    public bool ballCanStart = false;

    public LogicScript logic; 


    void Start ()
    {
        logic = GameObject.Find("LogicSystem").GetComponent<LogicScript>();
        
    }

   

    // Start is called before the first frame update
    void Update()
    {               
        ballSpeed = logic.ballRate;
        // Let's put all this in an if statement to wait for the game to start before difficulty chosen.
        if (ballCanStart == true)
        {
            
        //need to randomize the first ball of the game
            
            bool isRight = UnityEngine.Random.value >= 0.5f; // if 0== flase, else == true

            float xVelocity = -1f; //default velocity toward left side

            if (isRight == true) 
            {
                xVelocity = 1f; // then goes toward right side
            }

            float yVelocity = UnityEngine.Random.Range(-1, 1f); // randomize the up/down directions

            myRigidBody.velocity = new Vector2(xVelocity * ballSpeed, yVelocity * ballSpeed);// initiate the "push" toward radom x and y value * speed

            ballCanStart = false;

            
        }
    }




}
