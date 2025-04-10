using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateControllerBlendVariant : MonoBehaviour
{
    Animator animator;
    float velocity = 0.0f; // Variable to store the velocity of the character
    public float acceleration = 0.3f; // Acceleration rate for the character's movement
    public float deceleration = 0.5f; // Deceleration rate for the character's movement
    int velocityHash; // Hash for the velocity parameter in the Animator

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component attached to this GameObject
        velocityHash = Animator.StringToHash("Velocity"); // Convert the animation state name to a hash for performance
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w"); // Check if the W key is pressed
        bool runPressed = Input.GetKey("left shift"); // Check if the left shift key is pressed

        if(forwardPressed) // Check if the space key is pressed
        {
            velocity += Time.deltaTime*acceleration; // Increase the velocity over time
        }
        else
        {
            if(velocity > 0.0f) // Check if the velocity is greater than zero
            {
                velocity -= Time.deltaTime*deceleration; // Decrease the velocity over time
            }
            else
            {
                velocity = 0.0f; // Reset the velocity to zero if it goes negative
            }
            

        }

        animator.SetFloat(velocityHash, velocity); // Set the velocity parameter in the Animator
    }
}
