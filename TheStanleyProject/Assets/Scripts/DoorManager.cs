using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public bool opening = false;
    public bool closing = false;
    public bool startOpen = false;
    public Vector3 rotationAxis = new Vector3(0,1,0);
    private float rotationSpeed = 1.0f;
    private float currentRotation;
    private Quaternion cRotation;

    void Start()
    {
        if (startOpen)
        {
            opening = true;
        }
    }

    void Update()
    {
        //check
        
        cRotation = transform.rotation;
        currentRotation = cRotation.eulerAngles.y;
        //print(currentRotation);
        if (currentRotation > 0 && currentRotation < 270)
        {
            opening = false;
        }

        if (currentRotation < 269)
        {
            closing = false;
        }
        //move
        if (opening)
        {
            transform.Rotate(rotationAxis,-rotationSpeed);
        }else if (closing)
        {
            transform.Rotate(rotationAxis,rotationSpeed);
        }


    }

    public void openDoor()
    {
        if (currentRotation < 1)
        {
            opening = true;
        }
    }

    public void closeDoor()
    {
        if (currentRotation > 0 && currentRotation < 270)
        {
            closing = true;
        }
    }
}
