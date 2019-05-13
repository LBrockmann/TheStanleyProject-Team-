using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inBreakRoomTrigger : MonoBehaviour
{
    
    private bool _Audioplayed1;
    private bool _Audioplayed2;
    private bool _Audioplayed3;
    private bool _Audioplayed4;
    public AudioClip audioFile1;
    public AudioClip audioFile2;
    public AudioClip audioFile3;
    public AudioClip audioFile4;
    public float timerCap1;
    public float timerCap2;
    public float timerCap3;
    public float timerCap4;
    public float standStillTimer;
    public GameObject stanley;
    
    public GameManager gM;
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gM.stayOffice)
        {
            standStillTimer = standStillTimer + 1 * Time.deltaTime;
        }
        else
        {
            standStillTimer = 0;
        }
        
        if (standStillTimer > timerCap1)
        {
            print("play audio");
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
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stanley")
        {
            standStillTimer = standStillTimer + 1 * Time.deltaTime;
            print("stan man in break room");
        }
        print("someone in break room");

        gM.inBreakRoom = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Stanley")
        {
            standStillTimer = 0;
        }
        print("someone left break room");

        gM.inBreakRoom = false;
    }
}
