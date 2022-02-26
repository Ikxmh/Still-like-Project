using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorControls : MonoBehaviour
{
    private Animator animator;
    // increase performance by storing it in simpler data type 
    private int isWalkingHash;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        // puttting string into hash 
        isWalkingHash = Animator.StringToHash("IsWalking"); 
    }

    // Update is called once per frame
    void Update()
    {
        // Put the boolean parameter in variable 
        bool isWalking = animator.GetBool(isWalkingHash);
        
        // that way it can be performed once 
        bool forwardPressed = Input.GetKey("w");

        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true); 
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }
        
    }
}
