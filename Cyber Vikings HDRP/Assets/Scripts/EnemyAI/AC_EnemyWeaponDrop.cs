using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_EnemyWeaponDrop : MonoBehaviour
{
    public GameObject weapon;
    EnemyHealth enemyHealthScript;
    public Transform weaponPosition;
    public bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyHealth>();
    }
     
    
    // Update is called once per frame
    void Update()
    {
        if (enemyHealthScript.dead)
        {
            dead = true; 
            Instantiate(weapon, weaponPosition.position, weaponPosition.rotation);
        }
    }
}
