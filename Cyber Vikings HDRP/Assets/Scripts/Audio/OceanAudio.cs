using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanAudio : MonoBehaviour
{
    [SerializeField] AudioSource ambiantSound;

     private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag=="Player")
        {
            GetComponent<AudioSource>();
            ambiantSound.Play();
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>();
            ambiantSound.Stop();
        }
    }
}
