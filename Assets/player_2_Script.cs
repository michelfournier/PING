using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_2_Script : MonoBehaviour
{   
    public float moveSpeed;
      
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate((Vector2.up * Time.deltaTime) * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate((Vector2.down * Time.deltaTime) * moveSpeed);
        }
    }
}
