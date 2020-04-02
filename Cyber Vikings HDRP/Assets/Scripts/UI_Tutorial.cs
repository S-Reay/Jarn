using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Tutorial : MonoBehaviour
{
    public GameObject tutorialPanel;
    public GameObject text;
    public bool isFinal = false;
    float endTimer = 5f;

    public void Start()
    {
        tutorialPanel = GameObject.FindGameObjectWithTag ("Tutorial");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.SetActive(true);
            foreach (GameObject text in GameObject.FindGameObjectsWithTag("TutorialText"))
            {
                text.SetActive(false);
            }
            text.SetActive(true);
            if (isFinal)
            {
                StartCoroutine(Countdown());
            }
        }

    }
    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(5);
        tutorialPanel.SetActive(false);
    }
}