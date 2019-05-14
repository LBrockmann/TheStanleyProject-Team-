using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor_Lin : MonoBehaviour
{
    private Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = -4;
        transform.position= mousePosition;
    }
}
