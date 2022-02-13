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

    // backends variables 
    [SerializeField] private float speed = 12f; 


    // Update is called once per frame
    void Update()
    {
        // assigning it to the axes 
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // movement 

        /*
         * global coordinates 
         * (would move same way no matter what way our player is facing)
         Vector3 move = new Vector3(horizontalInput, 0f, verticalInput);
        */


        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput;


        characterController.Move(movement * speed * Time.fixedDeltaTime); 


    }
}
