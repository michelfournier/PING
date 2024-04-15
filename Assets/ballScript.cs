using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float ballSpeed;


   

    // Start is called before the first frame update
    void Start()
    {   
        //need to randomize the first ball of the game
        bool isRight = UnityEngine.Random.value >= 0.5f; // if 0== flase, else == true

        float xVelocity = -1f; //default velocity toward left side

        if (isRight == true) 
        {
            xVelocity = 1f; // then goes toward right side
        }

        float yVelocity = UnityEngine.Random.Range(-1, 1f); // randomize the up/down directions

        myRigidBody.velocity = new Vector2(xVelocity * ballSpeed, yVelocity * ballSpeed); // initiate the "push" toward radom x and y value * speed

       

    }

    // Update is called once per frame
    void Update()
    {
        

        // if ball touches invisible triggers, point to opponent. respawn ball
         
       
    }


}
