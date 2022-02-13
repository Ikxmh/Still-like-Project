using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // inputs 
    private float mouseX;
    private float mouseY;

    // an variable to rotate by
    [SerializeField] private float mouseSensitivity = 100f;

    // an player object that is being referenced
    public Transform playerBody;

    private float xRotation = 0f; 

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 40f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
