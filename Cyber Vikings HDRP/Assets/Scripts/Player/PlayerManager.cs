using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton
    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;

    private void Start()
    {
        player.transform.position = GameObject.FindGameObjectWithTag("PlayerSpawn").transform.position;
        player.transform.rotation = GameObject.FindGameObjectWithTag("PlayerSpawn").transform.rotation;
    }
}
