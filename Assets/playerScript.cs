using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{   
    public Rigidbody2D myRigidBody;
    public float playerSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myRigidBody.velocity = Vector2.up * playerSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myRigidBody.velocity = Vector2.down * playerSpeed;
        }
    }
}
