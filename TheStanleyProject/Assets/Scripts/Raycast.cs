using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float rayDistance = 1f;
    public Camera stanley;

    void Update()
    {
        //Ray myRay = new Ray(transform.position, transform.forward);

        Debug.DrawRay(stanley.transform.position, stanley.transform.forward * rayDistance, Color.blue);

        RaycastHit hit;

        if (Physics.Raycast(stanley.transform.position, stanley.transform.forward, out hit, rayDistance))
        {
            //print(hit.transform.tag);
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.tag == "Door")
                {
                    print("hit door");
                }
            }
            
        }
    }
}