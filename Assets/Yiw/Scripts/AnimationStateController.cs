using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour
{

    
    public Animator animator; // Reference to the Animator component

    int isWalkingHash; // Hash for the walking animation state
    int isRunningHash; // Hash for the running animation state

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component attached to this GameObject
        isWalkingHash   = Animator.StringToHash("isWalking"); // Convert the animation state name to a hash for performance
        isRunningHash   = Animator.StringToHash("isRunning"); // Convert the animation state name to a hash for performance
    }

    void Update()
    {
        bool isWalking = animator.GetBool("isWalking"); // Flag to check if the character is walking
        bool isRanning = animator.GetBool("isRunning"); // Flag to check if the character is running
        
        bool forwardPressed = Input.GetKey("w"); // Check if the W key is pressed
        bool runPressed= Input.GetKey("left shift"); // Check if the left shift key is pressed



        if(forwardPressed) // Check if the space key is pressed
        {
            Debug.Log("W key pressed"); // Log to the console
            animator.SetBool(isWalkingHash, true); // Set the animation state to true
        }else
        {
            animator.SetBool(isWalkingHash, false); // Set the animation state to false
        }

        if(forwardPressed && runPressed) // Check if the space key is pressed
        {
            
            animator.SetBool(isRunningHash, true); // Set the animation state to true
        }else
        {
            animator.SetBool(isRunningHash, false); // Set the animation state to false
        }

    }
}
