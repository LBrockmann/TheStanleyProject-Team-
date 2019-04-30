using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public bool opening = false;
        public bool closing = false;
        public bool startOpen = false;
        private bool print = false;
        public bool turnedRight = false;
        public bool turnedLeft = false;
        private Vector3 rotationAxis = new Vector3(0,1,0);
        private float rotationSpeed = 1;
        private float currentRotation;
        private Quaternion cRotation;

        public AudioClip closeDoorAudio;
        public AudioClip openDoorAudio;

        public int openDoorAudioTimer;
        public int closeDoorAudioTimer;
        private int cDAT;  //timer
        private int oDAT; //timer
        private bool openTimer = false;
        private bool closeTimer = false;
    
        void Start()
        {
            if (startOpen)
            {
                opening = true;
            }
    
            if (turnedRight || turnedLeft)
            {
                rotationAxis.y = -1;
                rotationSpeed = rotationSpeed * -1;
            }
        }
    
        void Update()
        {
            //check
            if (openTimer)
            {
                oDAT++;
                if (oDAT > openDoorAudioTimer)
                {
                    gameObject.GetComponent<AudioSource>().clip = openDoorAudio;
                    gameObject.GetComponent<AudioSource>().Play();
                    openTimer = false;
                }
            }

            if (closeTimer)
            {
                cDAT++;
                if (cDAT > closeDoorAudioTimer)
                {
                    gameObject.GetComponent<AudioSource>().clip = closeDoorAudio;
                    gameObject.GetComponent<AudioSource>().Play();
                    closeTimer = false;
                }
            }
            
            
            
            cRotation = transform.rotation;
            currentRotation = cRotation.eulerAngles.y;
            if (print)
            {
                print(currentRotation);
            }
    
            if (rotationAxis.y > 0)
            {
                if (currentRotation > 0 && currentRotation < 270)
                {
                    opening = false;
                }
    
                if (currentRotation < 269)
                {
                    closing = false;
                }
            }
    
            if (turnedRight)
            {
                if (currentRotation > 90)
                {
                    opening = false;
                }
    
                if (currentRotation > 89 && currentRotation < 270)
                {
                    closing = false;
                }
            }

            if (turnedLeft)
            {
                if (currentRotation < 180)
                {
                    opening = false;
                }
    
                if (currentRotation > 268)
                {
                    closing = false;
                }
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
        opening = true;
        if (!gameObject.GetComponent<AudioSource>().isPlaying)
        {
            int x = 0;
            while (x < openDoorAudioTimer)
            {
                x++;
            }

            

        }
    }

    public void closeDoor()
    {
        closing = true;
        if (!gameObject.GetComponent<AudioSource>().isPlaying)
        {
            int x = 0;
            while(x < closeDoorAudioTimer)
            {
                x++;
            }

            gameObject.GetComponent<AudioSource>().clip = openDoorAudio;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
