using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Player Speed

    void Update()
    {
        // WSAD Control
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // Move where camera center
        Vector3 movement = transform.right * moveHorizontal + transform.forward * moveVertical;
        transform.Translate(movement, Space.World); // acctual move in world
    }
}