﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AC_RuneImage : MonoBehaviour
{
    [SerializeField] private Image doubleJump;
    [SerializeField] private Image dashImage;
    [SerializeField] private Image glideImage;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject runeLight;

    public void Awake()
    { 
        
            doubleJump.enabled = false;
            dashImage.enabled = false;
            glideImage.enabled = false;
            runeLight.SetActive(false);
        
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (player.gameObject.tag == "Player")
        {
            doubleJump.enabled = true;
            dashImage.enabled = true;
            glideImage.enabled = true;
            runeLight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (player.gameObject.tag == "Player")
        {
            doubleJump.enabled = false;
            dashImage.enabled = false;
            glideImage.enabled = false;
            runeLight.SetActive(false);
        }
    }
}