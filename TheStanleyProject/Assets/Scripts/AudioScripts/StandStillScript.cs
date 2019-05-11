using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandStillScript : MonoBehaviour
{

    public float standStillTimer;
    public AudioClip audioFile1;
    private bool _playClip1;
    private bool _stanleystandsstill;
    private bool _Audioplayed;
   

    public float timerCap1;
    // Start is called before the first frame update
    void Start()
    {
        _Audioplayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) != true && Input.GetKey(KeyCode.S) != true &&Input.GetKey(KeyCode.D) != true && Input.GetKey(KeyCode.W) != true )
        {
            _stanleystandsstill = true;
        }
        else
        {
            _stanleystandsstill = false;
            standStillTimer = 0;
        }

        if (_stanleystandsstill == true)
        {
            standStillTimer = standStillTimer + 1 * Time.deltaTime;
        }

        if (standStillTimer > timerCap1)
        {
            if (_Audioplayed == false)
            {
                this.GetComponent<AudioSource>().Pause();
                this.GetComponent<AudioSource>().clip = audioFile1;
                this.GetComponent<AudioSource>().Play();
             _Audioplayed = true;
            }
            
            
        }

      
    }
}
