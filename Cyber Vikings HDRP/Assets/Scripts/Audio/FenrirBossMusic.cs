using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FenrirBossMusic : MonoBehaviour
{
    public AudioSource FenrirBoss;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Has Entered Trigger");
            FenrirBoss.Play();
        }
    }
    //void OnTriggerExit(Collider other)
    //{
        //if (other.tag == "Player")
        //{
            //GetComponent<AudioSource>().Stop();
        //}
    //}
}
