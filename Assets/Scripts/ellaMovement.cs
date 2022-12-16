using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ellaMovement : MonoBehaviour
{
   public float speed;
    public float rotationSpeed;
    public float jumpSpeed;

    private CharacterController characterController;
    private float ySpeed;
    private float originalStepOffset; 
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;
    }

    void Update()
    {

        if (Input.GetKey("s"))
        {
            verticalInput = 1;
        }
        else
        {
            verticalInput = 0;
        }

        if (Input.GetKey("a"))
        {
            horizontalInput = 1;
        }
        else
        {
            horizontalInput = 0;
        }

        if (Input.GetKey("w"))
        {
            verticalInput = -1;
        }

        if (Input.GetKey("d"))
        {
            horizontalInput = -1;
        }

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded)
        {
            characterController.stepOffset = originalStepOffset;
            ySpeed = -0.5f;

            if (Input.GetButtonDown("Jump"))
            {
                ySpeed = jumpSpeed;
            }
        }
        else
        {
            characterController.stepOffset = 0;
        }

        Vector3 velocity = movementDirection * magnitude;
        velocity.y = ySpeed;

        characterController.Move(velocity * Time.deltaTime);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
