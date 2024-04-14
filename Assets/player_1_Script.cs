using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{   
    public float moveSpeed;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //GetKey vs GetKeyDown to have it continuously listening to input = holding the key down.
        {
            transform.Translate((Vector2.up * Time.deltaTime) * moveSpeed); //the transform property of the object translates toward direction.
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate((Vector2.down * Time.deltaTime) * moveSpeed);
        }
    }
}
