using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class UI_Tutorial : MonoBehaviour
{
    [SerializeField] private Image tutorialPanel;
    [SerializeField] private Text text;


    public void Awake ()
    {
        tutorialPanel.enabled = false;
        text.enabled=false;
    }
    
    public void OnTriggerEnter(Collider player)
    { if (player.gameObject.tag== "Player")
        {
            tutorialPanel.enabled =true;
            text.enabled =true;
            Debug.Log("player entered trigger");
                    }
        
      
    }

    public void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            tutorialPanel.enabled = false;
            text.enabled =false;
            Debug.Log("player entered trigger");
            
        }

    }






        //public void OnTriggerExit(Collider player)
        //{

        //    
        //    Debug.Log("player exited trigger");

        //}

}



