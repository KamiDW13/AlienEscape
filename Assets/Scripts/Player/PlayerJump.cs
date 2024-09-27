using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;   // Jump Power
    public LayerMask groundLayers; // Ground
    public Transform groundCheck;  // IsPlayerTouchingGround ?

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // check rigb
    }

    void Update()
    {
        // IsPlayerTouchingGround atm ?
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.2f, groundLayers);

        // Jump after pressing Space
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}