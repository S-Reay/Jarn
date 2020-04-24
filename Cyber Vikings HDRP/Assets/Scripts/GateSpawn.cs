using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSpawn : MonoBehaviour
{
    public MeshRenderer mesh;
    public BoxCollider trigger;
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mesh = gameObject.GetComponent<MeshRenderer>();
            mesh.enabled = true;
            trigger = gameObject.GetComponent<BoxCollider>();
            trigger.isTrigger = false;
        }
    }
}
