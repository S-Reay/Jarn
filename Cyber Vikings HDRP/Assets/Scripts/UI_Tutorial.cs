using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Tutorial : MonoBehaviour
{
    public GameObject tutorialPanel;
    public GameObject text;
    public GameObject meleeObject;

    private void start()
    {
        tutorialPanel.SetActive(false);
        text.SetActive(false);
    }
    public void OnTriggerEnter()
    {
        tutorialPanel.SetActive(true);
        text.SetActive(true);
        meleeObject.SetActive(true);
    }

    public void OnTriggerExit()
    {
        tutorialPanel.SetActive(false);
        text.SetActive(false);
        meleeObject.SetActive(false);
    }
}