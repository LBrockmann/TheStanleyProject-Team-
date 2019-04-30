using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInOffice : MonoBehaviour
{
    // Start is called before the first frame update
    
    private bool _Audioplayed1;
    private bool _Audioplayed2;
    private bool _Audioplayed3;
    private bool _Audioplayed4;
    private bool _Audioplayed5;
    public AudioClip audioFile1;
    public AudioClip audioFile2;
    public AudioClip audioFile3;
    public AudioClip audioFile4;
    public AudioClip audioFile5;
    public float timerCap1;
    public float timerCap2;
    public float timerCap3;
    public float timerCap4;
    public float timerCap5;
    private float standStillTimer;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stanley")
        {
            standStillTimer = standStillTimer + 1 * Time.deltaTime;
        }
        
        if (standStillTimer > timerCap1)
        {
            if (_Audioplayed1 == false)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audioFile1);
                _Audioplayed1 = true;
            }
        }
        if (standStillTimer > timerCap2)
        {
            if (_Audioplayed2 == false)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audioFile2);
                _Audioplayed2 = true;
            }
        }
        
        if (standStillTimer > timerCap3)
        {
            if (_Audioplayed3 == false)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audioFile3);
                _Audioplayed3 = true;
            }
        }
        if (standStillTimer > timerCap4)
        {
            if (_Audioplayed4 == false)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audioFile4);
                _Audioplayed4 = true;
            }
        }
        if (standStillTimer > timerCap5)
        {
            if (_Audioplayed5 == false)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audioFile5);
                _Audioplayed5 = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Stanley")
        {
            standStillTimer = 0;
        }
    }
}
