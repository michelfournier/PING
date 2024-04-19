using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to get the Text class
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class gameoverScript : MonoBehaviour
{
    

    public void rematch()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quitting..."); 
    }


    public void backToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
