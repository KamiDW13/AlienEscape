using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;   // player position
    public float chaseSpeed = 5f;  // speed

    private NavMeshAgent agent; // navigate

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player != null)
        {
            // start follow player
            agent.SetDestination(player.position);
            agent.speed = chaseSpeed;
        }
    }
}
