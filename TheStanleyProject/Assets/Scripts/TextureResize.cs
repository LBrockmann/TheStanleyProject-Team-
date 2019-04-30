﻿using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class TextureResize : MonoBehaviour 
{

    public float scaleFactor = 5.0f;
    Material mat;
    // Use this for initialization
    void Start () 
    {
        Debug.Log("Start");
        GetComponent<Renderer>().material.mainTextureScale = new Vector2 (transform.localScale.x / scaleFactor , transform.localScale.z / scaleFactor);
    }

    // Update is called once per frame
    void Update () 
    {

        if (transform.hasChanged && Application.isEditor && !Application.isPlaying) 
        {
            Debug.Log("The transform has changed!");
            GetComponent<Renderer>().material.mainTextureScale = new Vector2 (transform.localScale.x / scaleFactor , transform.localScale.z / scaleFactor);
            transform.hasChanged = false;
        } 

    }
}