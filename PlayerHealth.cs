using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

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
        player.transform.position = respawnPoint.position;
    }
}
