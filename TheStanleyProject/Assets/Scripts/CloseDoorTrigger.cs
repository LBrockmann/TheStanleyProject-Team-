using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorTrigger : MonoBehaviour
{  
    public GameObject doorHingeToClose;
    private DoorManager doorManagerScript;

    void Start()
    {
        doorManagerScript = doorHingeToClose.GetComponent<DoorManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        doorManagerScript.closeDoor();
    }
}
