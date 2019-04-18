using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float rayDistance = 1f;
    public Camera stanley;
    public int _clickCount = 0;
    private float _timer;
    public int clickCap;
    public GameObject stanleyObject;
    public AudioClip clickAudioClip;
    private bool _audioPlayed;

    void Start()
    {
        _audioPlayed = false;
    }
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
                _clickCount++;
                if (hit.transform.tag == "Door")
                {
                    print("hit door");
                }
            }
            
        }

        if (_timer > 15)
        {
            _timer = 0;
            _clickCount = 0;
        }

        if (_clickCount >= clickCap)
        {
            if (_audioPlayed == false && stanleyObject.GetComponent<AudioSource>().isPlaying == false)
            {
                stanleyObject.GetComponent<AudioSource>().PlayOneShot(clickAudioClip);
                _audioPlayed = true;
            }
            
        }
        
        
        _timer = _timer + 1 * Time.deltaTime;
    }
}