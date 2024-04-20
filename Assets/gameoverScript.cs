using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to get the Text class
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class gameoverScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public void Rematch()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quitting..."); 
    }


    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResumePlay()
    {      
        pauseMenu.SetActive(false);
      
    }

}
