using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Mouse Sensitivity
    public Transform playerBody; // Player body

    private float xRotation = 0f; // Camera move X

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Cursor center block
    }

    void Update()
    {
        // Mouse read
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Camera move Y
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Camera lock view 90

        // Camera rotation
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // player body rotation
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
