using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PhoneCallAudio : MonoBehaviour
{
    public GameManager gM;

    public AudioClip phoneRing;

    public AudioClip VOICE_S1;
    public AudioClip VOICE_S2;

    public float volumePhoneCall;
    public float volumeVoiceLines;
    
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Ringing()
    {
        gameObject.GetComponent<AudioSource>().volume = volumePhoneCall;
        gM.phoneCall = true;
        gameObject.GetComponent<AudioSource>().clip = phoneRing;
        gameObject.GetComponent<AudioSource>().Play();
        

    }

    void AnswerPhone()
    {
        gameObject.GetComponent<AudioSource>().volume = volumeVoiceLines;
        gameObject.GetComponent<AudioSource>().clip = VOICE_S1;
        gameObject.GetComponent<AudioSource>().Play();
        
    }

    void AcceptOrder()
    {
        gameObject.GetComponent<AudioSource>().clip = VOICE_S2;
        gameObject.GetComponent<AudioSource>().Play();
        gM.paperOrdered = true;
    }
}
