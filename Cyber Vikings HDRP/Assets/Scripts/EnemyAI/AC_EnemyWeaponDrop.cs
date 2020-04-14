using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AC_EnemyWeaponDrop : MonoBehaviour
{
    public GameObject weapon;
    EnemyHealth enemyHealthScript;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealthScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyHealth>();
    }
    private void Awake()
    {
        weapon.SetActive(false);
    }


    
    // Update is called once per frame
    void Update()
    {
        if (enemyHealthScript.dead)
        {
            weapon.SetActive(true);
        }
    }
}
