using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 200;
    public bool dead = false;
    
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();

        }
    }

    public void Die()
    {
        dead = true;
    }
}
