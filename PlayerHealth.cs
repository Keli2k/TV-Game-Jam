
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   
    public int health = 1;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Die"))
            health -= 1;
        

        if (health <= 0)
        {
            
            Die();
        }
    }

    void Die()
    {

        Destroy(gameObject);
    }
}

