using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JH_PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public string mainMenuScene;
    public string reloadScene;

    public GameObject pauseMenuUI;
    public GameObject pauseOptionsMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void RestartGame()
    {
        Debug.Log("I think I'm getting this");
        Time.timeScale = 1f;                    // Might not need these
        GameIsPaused = false;                   // Definately needed them
        SceneManager.LoadScene(reloadScene); 
    }

    // Something for the options menu (will investigate)

    public void OptionsUI()
    {
        pauseOptionsMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    // Code for return to main menu capabilities in case we need them

    // public void LoadMenu() // Being used to test problem with option button in pause menu
    // {
        // Debug.Log("This is on the wrong button for testing");
        // Time.timeScale = 1f;
        // SceneManager.LoadScene(mainMenuScene);
    // }

    public void QuitGame()
    {
        Debug.Log("Yayyyy ... it works!!!");
        Application.Quit();
    }
}
