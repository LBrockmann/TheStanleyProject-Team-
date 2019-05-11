using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 
 * This script controlls the movement of Stanley using WASD
 * 
 * @author Zaiyun Lin
 */

public class CharacterMovement2 : MonoBehaviour
{
    private float slowdownFactor = 0.2f;


    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    private float gravity = 20.0f;
    public AudioSource footStep;
    public static Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
    
        if (characterController.isGrounded)
        {
            moveDirection.y = 0.0f;
            moveDirection.x = Input.GetAxis("Horizontal");
            moveDirection.z = Input.GetAxis("Vertical");

            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        
            //if (Input.GetButton("Jump"))
            //{
            //    moveDirection.y = jumpSpeed;
            //}
            if(Input.GetButton("Horizontal")| Input.GetButton("Vertical"))
            {
                if (!footStep.isPlaying)
                {
                    footStep.Play();
                }
            }
            else
            {
                footStep.Stop();
            }
        }
        else
        {
            moveDirection.x = Input.GetAxis("Horizontal")*speed;
            moveDirection.z = Input.GetAxis("Vertical")*speed;
            moveDirection = transform.TransformDirection(moveDirection);


        }
     

        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    

        if (Input.GetKey(KeyCode.E))
        {
            slowMo();
        }
        else
        {
            normalMo();
        }

    }
    private void slowMo()
    {
        print(Time.timeScale);
        print(Time.fixedDeltaTime);
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = slowdownFactor * 0.02f;

    }
    private void normalMo()
    {
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02f;

    }
  
}
