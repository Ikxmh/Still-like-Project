using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Inputs variables 
    private float horizontalInput;
    private float verticalInput;

    // reference to the Character Controller
    public CharacterController characterController;

    // GroundCheck variables
    public Transform groundCheck; 
    [SerializeField] private float groundDistance = 0.5f;
    public LayerMask groundMask;
    private bool isGrounded; 

    // backends variables 
    [SerializeField] private float speed = 12f;

    // gravity variables 
    Vector3 velocity;
    [SerializeField] private float gravity = -9.81f; 

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); 

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // assigning it to the axes 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // movement 

        /*
         * global coordinates 
         * (would move same way no matter what way our player is facing)
         Vector3 move = new Vector3(horizontalInput, 0f, verticalInput);
        */

        // getting the local coords
        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput;

        // move the character using character controller 
        characterController.Move(movement * speed * Time.fixedDeltaTime);


        // setting up gravity 

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime); 


    }
}
