using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody; // Assign your player GameObject here

    public Transform orientation;

    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock cursor to center
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //playerBody.Rotate(Vector3.up * mouseX); // Rotate player horizontally

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Clamp vertical rotation

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f); // Apply vertical rotation to camera
        orientation.rotation = Quaternion.Euler(0f, yRotation, 0f);
    }
}
