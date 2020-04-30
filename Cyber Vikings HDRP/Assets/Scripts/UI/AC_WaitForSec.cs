using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_WaitForSec : MonoBehaviour
{
    [SerializeField] private Image tutorialPanel;
    [SerializeField] private Text text;

    public void Awake()
    {
        tutorialPanel.enabled = false;
        text.enabled = false;
        StartCoroutine("WaitForSec");
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        tutorialPanel.enabled = true;
        text.enabled = true;

        Debug.Log("coroutine started");
    }


      

    public void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            tutorialPanel.enabled = false;
            text.enabled = false;
            Debug.Log("player entered trigger");

        }

    }

}
