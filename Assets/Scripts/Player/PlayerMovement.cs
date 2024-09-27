using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private float originalSpeed; 
    public float sneakSpeedMultiplier = 0.5f; 
    public bool isSneaking = false; 

    void Start()
    {
        originalSpeed = moveSpeed; 
    }

    void Update()
    {
        HandleSneakInput(); 
        MovePlayer(); 
    }

    void HandleSneakInput()
    {
        
        if (Input.GetKey(KeyCode.C))
        {
            isSneaking = true; 
            moveSpeed = originalSpeed * sneakSpeedMultiplier; 
        }
        else
        {
            isSneaking = false; 
            moveSpeed = originalSpeed; 
        }
    }
    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        
        Vector3 movement = transform.right * moveHorizontal + transform.forward * moveVertical;
        transform.Translate(movement, Space.World); 
    }

}

