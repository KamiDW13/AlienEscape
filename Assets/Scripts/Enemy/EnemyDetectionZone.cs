using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    public GameObject enemy;   // enemy
    private EnemyAI enemyAI;   // enemy AI

    void Start()
    {
        
        enemyAI = enemy.GetComponent<EnemyAI>();
        enemyAI.enabled = false; // at start AI Off
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                if (!playerMovement.isSneaking)
                { 
                    
                    enemyAI.enabled = true;
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Is player still in zone ?
        if (other.CompareTag("Player"))
        {
            // stop AI 
            enemyAI.enabled = false;
        }
    }
}
