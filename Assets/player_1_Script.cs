using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{   
    public float moveSpeed;

    public LogicScript logic;

    AudioSource audioSound;
         
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.Find("LogicSystem").GetComponent<LogicScript>();
        audioSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = logic.p1Rate;

        if (Input.GetKey(KeyCode.W)) //GetKey vs GetKeyDown to have it continuously listening to input = holding the key down.
        {
            transform.Translate((Vector2.up * Time.deltaTime) * moveSpeed); //the transform property of the object translates toward direction.
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate((Vector2.down * Time.deltaTime) * moveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSound.Play();             

    }      
}
