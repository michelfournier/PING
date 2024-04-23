using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine;

public class TriggerRightScript : MonoBehaviour
{

    public LogicScript logic;
    public GameObject ball;
    private float timeDelay = 1;    
    public bool ballDestroyed = false;

    public Vector3 startPositionPlay1Right;
    public Vector3 startPositionPlay2Right;
    public Vector3 startPositionPlayCPURight;

    public GameObject player1Right;
    public GameObject player2Right;

    public GameObject playerCPURight;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


        //Get initial position of players to reset them in place after each point

        player1Right = GameObject.Find("player1");
        //play1CodeRight = player1Right.GetComponent<playerScript>();
        startPositionPlay1Right = player1Right.transform.position; //play1CodeRight.positionPlay1;

        if (SceneManager.GetActiveScene().name == "Court") // if 1vs1 mode 
        {
            player2Right = GameObject.Find("player2");

            startPositionPlay2Right = player2Right.transform.position;
        }
        else if (SceneManager.GetActiveScene().name == "CourtCPU") // if playing vs cpu
        {
            playerCPURight = GameObject.Find("CPU");

            startPositionPlayCPURight = playerCPURight.transform.position;
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
        logic.addScoreP1(1);

        Destroy(GameObject.FindGameObjectWithTag("ballz"));
        
        timeDelay = 1000f;
        
        ballDestroyed = true;
             
    }    

    private void resetThePlayField()
    {
        player1Right.transform.position = startPositionPlay1Right;

        if (SceneManager.GetActiveScene().name == "Court") {
            player2Right.transform.position = startPositionPlay2Right;
        }
        else if (SceneManager.GetActiveScene().name == "CourtCPU")
        {
            playerCPURight.transform.position = startPositionPlayCPURight;
        }        
    }

    private void delayedServe()
    {
        Instantiate(ball, new Vector3(0, 0, 0), transform.rotation);
    }
}
