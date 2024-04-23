using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine;

public class TriggerLeftScript : MonoBehaviour
{

    public LogicScript logic;
    public GameObject ball;
    private float timeDelay = 1;    
    public bool ballDestroyed = false;

    public Vector3 startPositionPlay1;
    public Vector3 startPositionPlay2;
    public Vector3 startPositionPlayCPU;

    public GameObject player1;
    public GameObject player2;

    public GameObject playerCPU;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


        //Get initial position of players to reset them in place after each point

        player1 = GameObject.Find("player1");
        //play1CodeRight = player1Right.GetComponent<playerScript>();
        startPositionPlay1 = player1.transform.position; //play1CodeRight.positionPlay1;

        if (SceneManager.GetActiveScene().name == "Court") // if 1vs1 mode 
        {
            player2 = GameObject.Find("player2");

            startPositionPlay2 = player2.transform.position;
        }
        else if (SceneManager.GetActiveScene().name == "CourtCPU") // if playing vs cpu
        {
            playerCPU = GameObject.Find("CPU");

            startPositionPlayCPU = playerCPU.transform.position;
        }

        
        

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

                resetThePlayField();
                Invoke("delayedServe", 2);

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

    private void resetThePlayField()
    {
        player1.transform.position = startPositionPlay1;

        if (SceneManager.GetActiveScene().name == "Court") {
            player2.transform.position = startPositionPlay2;
        }
        else if (SceneManager.GetActiveScene().name == "CourtCPU")
        {
            playerCPU.transform.position = startPositionPlayCPU;
        }        
    }

    private void delayedServe()
    {
        Instantiate(ball, new Vector3(0, 0, 0), transform.rotation);
    }
}
