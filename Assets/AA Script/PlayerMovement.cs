using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkingSpeed = 10f;
    public float runningSpeed = 17f;
    public float jumpSpeed = 10f;
    private float gravity = -9.81f;
    private float verticalVelocity = 0f;

    private CharacterController characterController;
    private float currentSpeed;
    private Vector3 moveDirection;

    // Initialize the CharacterController and set default speed
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        currentSpeed = walkingSpeed;
    }

    void Update()
    {
        // Reset the movement direction each frame
        moveDirection = Vector3.zero;

        // Get input for horizontal (X) and vertical (Z) movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Set speed based on whether the player is holding down Shift
        currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runningSpeed : walkingSpeed;

        // Move only when input exceeds a small threshold to avoid drift
        if (Mathf.Abs(moveX) > 0.1f || Mathf.Abs(moveZ) > 0.1f)
        {
            moveDirection = (transform.right * moveX + transform.forward * moveZ).normalized * currentSpeed;
        }

        // Handle jumping and gravity
        if (characterController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                verticalVelocity = jumpSpeed; // Jump upwards when on the ground
            }
            else
            {
                verticalVelocity = 0f; // Reset vertical velocity when grounded
            }
        }
        else
        {
            // Apply gravity over time when not grounded
            verticalVelocity += gravity * Time.deltaTime;
        }

        // Combine horizontal and vertical movement
        moveDirection.y = verticalVelocity;

        // Apply movement to the CharacterController
        characterController.Move(moveDirection * Time.deltaTime);
    }
}

