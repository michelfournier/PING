using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    
    public void PlayCPU()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Quitgame()
    {
        Application.Quit();        
    }

}
