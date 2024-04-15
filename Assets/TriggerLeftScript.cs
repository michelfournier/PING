using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TriggerLeftScript : MonoBehaviour
{

    public LogicScript logic;
    public GameObject ball;
    private float timeDelay = 1;

    private bool ballDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 
     
    }

    // Update is called once per frame
    void Update()
    {
        if (ballDestroyed == true)
        {   
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
        Debug.Log("+1 for P2");
        Destroy(GameObject.FindGameObjectWithTag("ballz"));
        Debug.Log("Destroyed");
        timeDelay = 1000f;
        ballDestroyed = true;
        Debug.Log(ballDestroyed);     

    }    
}
