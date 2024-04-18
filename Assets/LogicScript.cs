using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class LogicScript : MonoBehaviour
{   


    public int player1Score;
    public int player2Score;
    public Text scoreText1;
    public Text scoreText2;
    public GameObject gameOverScreen;

    


    public float ballRate;

    public float p1Rate;

    public float p2Rate; 

 


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void addScoreP1(int scoreToAdd)
    {
        player1Score += scoreToAdd;
        scoreText1.text = player1Score.ToString();
    }        

    public void addScoreP2(int scoreToAdd)
    {
        player2Score += scoreToAdd;
        scoreText2.text = player2Score.ToString();
    }  

    public void gameOver()
    {
        gameOverScreen.SetActive(true);    // TO DO

    }

    void Update()
    {
        /*if (player1Score == 21 || player2Score == 21)
        {
            
        } */ // TO DO
    }


}
