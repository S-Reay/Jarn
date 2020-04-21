using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTrigger : MonoBehaviour
{
    public PlayableDirector cutscene;

    private void OnTriggerEnter(Collider other)
    {
        cutscene.Play();
    }
}
