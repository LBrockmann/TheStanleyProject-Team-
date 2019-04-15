using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAudioTrigger : MonoBehaviour
{

    //public GameObject Stanley;  you dont need this bc u check for the tag and can access stanly when he enters the trigger

    public AudioClip audioFile;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

 void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Stanley" && other.GetComponent<AudioSource>().isPlaying == false) //If Stanley collides with your trigger and the narrator isn't talking
        {
                other.GetComponent<AudioSource>().PlayOneShot(audioFile); //it'll play whichever audio clip you have dragged into this script on stanley's audiosource
                Debug.Log("play: " + other.GetComponent<AudioSource>().clip + Time.time); //Get this debug working
                Destroy(this.gameObject);

        }
    }
}
