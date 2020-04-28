using UnityEngine;
using UnityEngine.Audio;

public class CharacterStats : MonoBehaviour
{
    public Stat maxHealth;
    public int CurrentHealth { get; private set; }

    public Stat damage;
    public Stat armour;
    public Stat moveSpeed;
    public Stat jumpHeight;
    public AudioClip audioClip;


    public virtual void Awake()
    {
        CurrentHealth = maxHealth.GetValue();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            TakeDamage(10);
        }
    }

    public virtual int TakeDamage(int damage)
    {
        damage -= armour.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);  //Ensure damage never drops below zero which would cause healing on hit

        CurrentHealth -= damage;
        Debug.Log(transform.name + " took " + damage + " damage.");

        if (CurrentHealth <= 0)
        {
            Die();
        }
        return damage;  //Returns damage taken to display on a damage indicator


    }

    public virtual void Die()
    {
        Debug.Log(transform.name + " died.");
    }
}
