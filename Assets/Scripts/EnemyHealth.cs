using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyHealth : MonoBehaviour
{
    public int health = 3;  

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(1); 
            Destroy(other.gameObject); 
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Otrzymane obrazenia: " + damage + ", pozostale zdrowie: " + health);

        
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