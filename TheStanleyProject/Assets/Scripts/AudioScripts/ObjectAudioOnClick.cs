using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAudioOnClick : MonoBehaviour
{
    public AudioClip clip;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayClip()
    {
        if (!this.gameObject.GetComponent<AudioSource>().isPlaying)
        {
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
