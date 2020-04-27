using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_EnemyWeaponDrop : MonoBehaviour
{
    public GameObject weapon;
    EnemyHealth enemyHealthScript;
    public Transform weaponPosition;
    public int health = 200;
    public bool dead = false;
   

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyHealth>();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0f)
        {
           dead = true;
           Instantiate(weapon, weaponPosition.position, weaponPosition.rotation);

        }
    }

    //public void dropWepon()
    //  {
    //      if (EnemyHealthScipt.Die)
    //      {
    //          dead = true;
    //          Instantiate(weapon, weaponPosition.position, weaponPosition.rotation);
    //      }
    //  }



}
