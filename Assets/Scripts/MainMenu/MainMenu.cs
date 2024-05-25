using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
       
        SceneManager.LoadScene("UserResearchValley");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void WhatIsUX()
    {
        SceneManager.LoadScene("whatisux");
    }

    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
