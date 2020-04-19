using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class JH_OptionsMenu : MonoBehaviour
{
    public GameObject pauseOptionsMenuUI;

    public AudioMixer audioMixer;

    Resolution[] resolutions;

    public Dropdown resolutionDropdown;

    private void Start()
    {
        // resolutions = Screen.resolutions;

        var resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    //void Update()
    //{
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
           // pauseOptionsMenuUI.SetActive(false);
            //Camera.main.GetComponent<MouseLook>().enabled = true;
            //Time.timeScale = 1f;
            //Cursor.lockState = CursorLockMode.Locked;
            //Cursor.visible = false;
            //JH_PauseMenu.GameIsPaused = false;
        //}
    //}

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume) // Starting the set up of this and will check in with Seth about progress. Info found at https://youtu.be/YOaYQrN1oYQ
    {
        audioMixer.SetFloat("mainVolume",volume); // This needs to be the same name as the exposed variable in the Audio Mixer window in Unity
    }
}
