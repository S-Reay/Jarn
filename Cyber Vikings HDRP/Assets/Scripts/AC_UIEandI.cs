﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AC_UIEandI : MonoBehaviour
{
    [SerializeField] private Image keyboardKeyButtonImage;
   

    public void Awake()
    {
        keyboardKeyButtonImage.enabled = false;
        

    }

    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            keyboardKeyButtonImage.enabled = true;
           

            Debug.Log("player entered trigger");
        }


    }

    public void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            keyboardKeyButtonImage.enabled = false;
            
            
            Debug.Log("player exited trigger");

        }

    }
}
