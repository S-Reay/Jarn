using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public CharacterController controller;
    public float currentSpeed;
    public float baseSpeed;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    bool hasDoubleJumped = false;
    public bool canDoubleJump = false;
    public bool canGlide = false;
    public bool canDash = false;
    public float dashDecayRate;
    float dashCooldown;

    private void Start()
    {
        currentSpeed = baseSpeed;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded)
        {
            hasDoubleJumped = false;
        }

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }
        
        //Controls
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if ((x != 0 || z != 0) && canDash && Input.GetButtonDown("Dash") && dashCooldown <= 0f)
        {
            currentSpeed *= 6;
            dashCooldown = 3f;
        }
        if (currentSpeed > baseSpeed)
        {
            currentSpeed -= Time.deltaTime * dashDecayRate;
        }
        else
        {
            currentSpeed = baseSpeed;
        }
        if (dashCooldown > 0f)
        {
            dashCooldown -= Time.deltaTime;
        }

        controller.Move(move * currentSpeed * Time.deltaTime);

        //Dash



        //Jump
        if (Input.GetButtonDown("Jump") && isGrounded)              //If the player presses Jump on the ground
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (Input.GetButtonDown("Jump") && !isGrounded && !hasDoubleJumped && canDoubleJump)        //If the player presses jump in the air but has not double jumped
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            hasDoubleJumped = true;
        }


        //Gravity
        if (canGlide && Input.GetButton("Glide"))
        {
            velocity.y += (gravity / 2) * Time.deltaTime;
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }
        controller.Move(velocity * Time.deltaTime);
    }
}
