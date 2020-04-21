using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : CharacterStats
{
    public float detectRadius;
    public override void Die()
    {
        base.Die();
        GetComponentInChildren<Animator>().SetBool("isDead", true);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectRadius);
    }
}