using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoorTrigger : MonoBehaviour
{  
    public GameObject doorHingeToClose;
    private DoorManager doorManagerScript;
    public bool thisClosesStanleysDoor = false;
    public bool thisClosesEnterBreakRoomDoor = false;
    public bool thisClosesExitBreakRoomDoor = false;

    public GameManager gM;

    void Start()
    {
        doorManagerScript = doorHingeToClose.GetComponent<DoorManager>();
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stanley")
        {
            doorManagerScript.closeDoor();
            if (thisClosesStanleysDoor)
            {
                gM.leftOffice = true;
            }
            if (thisClosesEnterBreakRoomDoor)
            {
                gM.inBreakRoom = true;
            }

            if (thisClosesExitBreakRoomDoor)
            {
                gM.inBreakRoom = false;
            }
        }
    }
}
