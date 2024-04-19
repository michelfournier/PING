using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class difficultyScript : MonoBehaviour
{
    public LogicScript logic;

    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();    

        logic.ballRate = 5f;
        logic.p1Rate = 3f;
        logic.p2Rate = 3f;  
        
    }
    public void HandleDiffRate(int val)
    {
        if (val == 0)
        {
            logic.ballRate = 5f;
            logic.p1Rate = 3f;
            logic.p2Rate = 3f;
        }
        if (val == 1)
        {
            logic.ballRate = 6f;
            logic.p1Rate = 4f;
            logic.p2Rate = 4f;
        }
        if (val == 2)
        {
            logic.ballRate = 7f;
            logic.p1Rate = 5f;
            logic.p2Rate = 5f;
        }
    }


}
