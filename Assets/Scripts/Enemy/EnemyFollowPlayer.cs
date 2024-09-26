using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform target; // Player body
    public float speed = 2f;  // Enemy Speed

    void Update()
    {
        // Calculate direction
        Vector3 direction = target.position - transform.position;
        direction.Normalize();  

        // Move Enemy to Player
        transform.position += direction * speed * Time.deltaTime;

        // Rotate enemy faceing player
        transform.LookAt(target);
    }
}