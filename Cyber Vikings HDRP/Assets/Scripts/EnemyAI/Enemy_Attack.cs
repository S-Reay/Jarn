using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public PlayerStats playerStats;
    private void Start()
    {
        playerStats = PlayerStats.instance;
    }
    public void AttackPlayer()
    {
        playerStats.TakeDamage(5);
    }
}
