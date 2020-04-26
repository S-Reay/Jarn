using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JH_PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    // public string mainMenuScene;
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
                // Debug.LogWarning("Escape was pressed (Entering Resume). Timescale is [" + Time.timeScale + "]");
                Resume();
                
            }
            else
            {
                // Debug.LogWarning("Escape was pressed (Entering Pause). Timescale is [" + Time.timeScale + "]");
                Pause();
            }
        }
    }

    // void OnGUI()    // {        // GUILayout.Label("Time.timeScale: " + Time.timeScale);    // }


    public void Resume()
    {
        // Debug.LogWarning("Entered (Resume). Timescale is [" + Time.timeScale + "]");
        pauseMenuUI.SetActive(false);
        pauseOptionsMenuUI.SetActive(false);
        // Camera.main.GetComponent<MouseLook>().enabled = true; // This was a attempt to have the game stop when in the pause menu which was done a result of issues
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameIsPaused = false;
    }

    void Pause()
    {
        // Debug.LogWarning("Entered (Pause). Timescale is [" + Time.timeScale + "]");
        pauseMenuUI.SetActive(true);
        pauseOptionsMenuUI.SetActive(false);
        // Camera.main.GetComponent<MouseLook>().enabled = false;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameIsPaused = true;
    }

    public void RestartGame()
    {
        // Debug.LogWarning("Entered (RestartGame). Timescale is [" + Time.timeScale + "]");
        // Debug.Log("I think I'm getting this");
        // Camera.main.GetComponent<MouseLook>().enabled = true;
        Time.timeScale = 1f;                    // Might not need these
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameIsPaused = false;                   // Definately needed them
        SceneManager.LoadScene(reloadScene); 
    }

    // Something for the options menu (will investigate)

    public void OptionsUI()
    {
        // Debug.LogWarning("Entered (OptionsUI). Timescale is [" + Time.timeScale + "]");
        pauseMenuUI.SetActive(false);
        pauseOptionsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameIsPaused = true;
    }



    // Code for return to main menu capabilities in case we need them

    public void LoadMenu(string sceneName) // Being used to test problem with option button in pause menu
    {
        // Debug.Log("This is on the wrong button for testing");
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameIsPaused = false; 
        SceneManager.LoadScene(sceneName);
    }

    //public void QuitGame()
    //{
        //Debug.Log("Yayyyy ... it works!!!");
        //Application.Quit();
    //}
}
