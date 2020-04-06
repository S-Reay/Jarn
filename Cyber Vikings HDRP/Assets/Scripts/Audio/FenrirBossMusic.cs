using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenrirBossMusic : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Has Entered Trigger");
            GetComponent<AudioSource>().Play();
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
