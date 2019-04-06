using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float rayDistance = 1f;
    public Camera player;

    void Update()
    {
        Ray myRay = new Ray(transform.position, transform.forward);

        Debug.DrawRay(myRay.origin, myRay.direction * rayDistance, Color.blue);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("insert tag here") && Input.GetKeyDown(KeyCode.E))
            {
                //interact script
            }
        }
    }
}