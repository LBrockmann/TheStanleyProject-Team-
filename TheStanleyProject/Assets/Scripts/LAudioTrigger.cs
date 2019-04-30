using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class LAudioTrigger : MonoBehaviour
{

    public bool interrupt = false;

    //public GameObject Stanley;  you dont need this bc u check for the tag and can access stanly when he enters the trigger

    public AudioClip audioFile;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

 void OnTriggerEnter (Collider other) //kate edited to add a non interrupt option
    {
        if (other.tag == "Stanley")
        {
            if (interrupt)
            {
                other.GetComponent<AudioSource>().Pause();
                other.GetComponent<AudioSource>().clip = audioFile;
                other.GetComponent<AudioSource>().Play();
                Debug.Log("play: " + other.GetComponent<AudioSource>().clip + Time.time);
                Destroy(this.gameObject);
            
            }
            else
            {
                if (!other.GetComponent<AudioSource>().isPlaying)
                {
                    other.GetComponent<AudioSource>().clip = audioFile;
                    other.GetComponent<AudioSource>().Play();
                    Debug.Log("play: " + other.GetComponent<AudioSource>().clip + Time.time);
                    Destroy(this.gameObject);
                }
            } 
        }
    }
}
