using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 
 * This script controlls the movement of Stanley using WASD
 * 
 * @author Zaiyun Lin
 */

public class CharacterMovement : MonoBehaviour
{
    public float speed = 6.0f;
    public float rotateSpeed = 6.0f;
    private float gravity = 400.0f;
  
    private Vector3 moveDirection =  Vector3.zero;
    private CharacterController controller;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        moveDirection.y -= gravity*Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    
    }
}
