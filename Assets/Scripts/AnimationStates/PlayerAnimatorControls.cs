using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorControls : MonoBehaviour
{
    private Animator animator;
    // increase performance by storing it in simpler data type 
    private int isWalkingHash;
    private int isWalkingBackwardHash;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        // puttting string into hash 
        isWalkingHash = Animator.StringToHash("IsWalking");
        isWalkingBackwardHash = Animator.StringToHash("IsWalkingBackward");
    }

    // Update is called once per frame
    void Update()
    {
        // Put the boolean parameter in variable 
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isWalkingBackward = animator.GetBool(isWalkingBackwardHash); 

        
        // that way it can be performed once 
        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");

        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true); 
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        else if (!isWalkingBackward && backwardPressed)
        {
            animator.SetBool(isWalkingBackwardHash, true);
        }

        else if (isWalkingBackward && !backwardPressed)
        {
            animator.SetBool(isWalkingBackwardHash, false); 
        }
        
    }
}
