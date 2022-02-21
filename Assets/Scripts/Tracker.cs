using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    [SerializeField] private float MouseSensivity = 100f;
    [SerializeField] private Transform PlayerTransform;

    float xRotation = 0f;
 
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        

    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        PlayerTransform.Rotate(Vector3.up * mouseX);
    }

   
}
