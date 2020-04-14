using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanAudio : MonoBehaviour
{
    [SerializeField] AudioSource beachSound;

     private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag=="Player")
        {
            GetComponent<AudioSource>();
            beachSound.Play();
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>();
            beachSound.Stop();
        }
    }
}
