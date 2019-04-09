using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAudioTrigger : MonoBehaviour
{

    public GameObject Stanley;

    public AudioClip audioFile;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

 void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Stanley" && Stanley.GetComponent<AudioSource>().isPlaying == false) //If Stanley collides with your trigger and the narrator isn't talking
        {
                Stanley.GetComponent<AudioSource>().PlayOneShot(audioFile); //it'll play whichever audio clip you have dragged into this script on stanley's audiosource
                Debug.Log("play: " + Stanley.GetComponent<AudioSource>().clip + Time.time); //Get this debug working
                Destroy(this.gameObject);

        }
    }
}
