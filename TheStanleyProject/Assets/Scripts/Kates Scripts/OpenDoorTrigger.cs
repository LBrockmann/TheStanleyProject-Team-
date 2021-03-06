﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorTrigger : MonoBehaviour
{
    public GameObject doorHingeToOpen;
    private DoorManager doorManagerScript;

    void Start()
    {
        doorManagerScript = doorHingeToOpen.GetComponent<DoorManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Stanley")
        {
            doorManagerScript.openDoor();
            Destroy(this.gameObject);
        }
       
    }
}
