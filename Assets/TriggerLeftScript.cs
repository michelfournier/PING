using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TriggerLeftScript : MonoBehaviour
{

    public LogicScript logic;
    public GameObject ball;

    private float timeDelay = 1;

    public bool ballDestroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (ballDestroyed == true && logic.player1Score != 11 && logic.player2Score != 11)
        {   
            timeDelay = 5000f;
            while (timeDelay > 0) 
            {
                timeDelay -= Time.deltaTime;
              
            }

            if (timeDelay <= 0) 
            {
                
                ballDestroyed = false;
                Instantiate(ball, new Vector3(0, 0, 0), transform.rotation);

            }
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScoreP2(1);

        Destroy(GameObject.FindGameObjectWithTag("ballz"));
        
        timeDelay = 1000f;
        
        ballDestroyed = true;
             

    }    
}
