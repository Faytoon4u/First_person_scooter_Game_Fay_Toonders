using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float currentSpeed;
    public float walkingSpeed = 10f; // makes the walking speed 
    public float runningSpeed = 17f; // running speed

    private float gravity = -0.5f;
    public float jumpSpeed = 20f;
    private float baseLineGravity;

    private float moveX;
    private float moveZ;
    private Vector3 move;

    public CharacterController characterController;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        currentSpeed = walkingSpeed;
        baseLineGravity = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * currentSpeed * Time.deltaTime;
        moveZ = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;

        move = transform.right*moveX +
               transform.up*gravity+
               transform.forward* moveZ;


        characterController.Move(move);

        // makes the runningspeed active by pressing shift 
        if (Input.GetKey(KeyCode.LeftShift))  
        {
            currentSpeed = runningSpeed;
        }
        else
        {
            currentSpeed = walkingSpeed;
        }

        // jumping bij pressing the spacebar
        if (characterController.isGrounded == true && Input.GetButtonDown("Jump")) // if the character is on the ground 
        {
            gravity = baseLineGravity;
            gravity *= -jumpSpeed;

        }

        if (gravity > baseLineGravity)
        {
            gravity -= 2 * Time.deltaTime;
        }

        //// jumpingggg
        //if (characterController.isGrounded == true && Input.GetButtonDown("Jump!")) 
        //{
        //    rb.AddForce(Vector3.up, ForceMode.Impulse );
        //}
       
    }
}
