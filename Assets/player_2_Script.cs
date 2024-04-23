using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_2_Script : MonoBehaviour
{   
    public float moveSpeed;

    public LogicScript logic;
    AudioSource audioSound;

    public Vector3 positionPlay2;
      
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("LogicSystem").GetComponent<LogicScript>();
        audioSound = GetComponent<AudioSource>();    
        positionPlay2 = transform.position;
 
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = logic.p2Rate;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate((Vector2.up * Time.deltaTime) * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate((Vector2.down * Time.deltaTime) * moveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSound.Play();             

    }     
}
