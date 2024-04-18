using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButton1v1 : MonoBehaviour
{

    public ballScript ballStandingBy;
    public GameObject setMenu;

    

    void Start() {

        ballStandingBy = GameObject.FindGameObjectWithTag("ballz").GetComponent<ballScript>();
        setMenu = GameObject.Find("Settings menu");
        

    }
    public void LaunchGame1v1()
    {   
        
        setMenu.SetActive(false);
        ballStandingBy.ballCanStart = true;
        

    }
}
