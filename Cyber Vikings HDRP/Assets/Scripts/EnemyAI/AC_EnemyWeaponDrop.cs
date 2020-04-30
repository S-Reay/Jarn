using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_EnemyWeaponDrop : MonoBehaviour
{
    public GameObject weapon;
    //EnemyHealth enemyHealthScript;
    public Transform weaponPosition;
    public GameObject enemy;
   

    // Start is called before the first frame update
    void Update()
    {
        

        if (enemy.GetComponent<CharacterStats>().CurrentHealth<=0f)
        {
            Instantiate(weapon, weaponPosition.position, weaponPosition.rotation);
            Debug.Log("gameobject dropped");
        }
    }


    











    //public void TakeDamage(int amount)
    //{
    //    health -= amount;
    //    if (health <= 0f)
    //    {
    //       isdead = true;
    //       Instantiate(weapon, weaponPosition.position, weaponPosition.rotation);

    //    }
    //}

    //public void dropWepon()
    //  {
    //      if (EnemyHealthScipt.Die)
    //      {
    //          dead = true;
    //          Instantiate(weapon, weaponPosition.position, weaponPosition.rotation);s
    //      }
    //  }



}
