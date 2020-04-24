using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AC_UIEandI : MonoBehaviour
{
    [SerializeField] private Image EButtonImage;
    [SerializeField] private Image IButtonImage;

    public void Awake()
    {
        EButtonImage.enabled = false;
        IButtonImage.enabled = false;

    }

    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            EButtonImage.enabled = true;
            IButtonImage.enabled = false;

            Debug.Log("player entered trigger");
        }


    }

    public void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            EButtonImage.enabled = false;
            IButtonImage.enabled = false;
            
            Debug.Log("player exited trigger");

        }

    }
}
