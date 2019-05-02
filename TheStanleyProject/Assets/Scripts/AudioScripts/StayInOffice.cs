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
    public float standStillTimer;
    public GameObject stanley;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (standStillTimer > timerCap1)
        {
            if (_Audioplayed1 == false)
            {
                Debug.Log("lineplays");
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile1;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed1 = true;
            }
        }
        if (standStillTimer > timerCap2)
        {
            if (_Audioplayed2 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile2;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed2 = true;
            }
        }
        
        if (standStillTimer > timerCap3)
        {
            if (_Audioplayed3 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile3;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed3 = true;
            }
        }
        if (standStillTimer > timerCap4)
        {
            if (_Audioplayed4 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile4;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed4 = true;
            }
        }
        if (standStillTimer > timerCap5)
        {
            if (_Audioplayed5 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile5;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed5 = true;
            }
        }

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stanley")
        {
            standStillTimer = standStillTimer + 1 * Time.deltaTime;
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
