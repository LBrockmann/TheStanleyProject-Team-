using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOffice_MainScene : MonoBehaviour
{
    public AudioClip b1_0; //30
    public AudioClip b1_1; //20
    public AudioClip b1_2; //5
    public AudioClip b1_3; //10
    public AudioClip b1_4; //10
    public AudioClip b1_5; //5
    public AudioClip b1_6; //10
    public AudioClip b1_7; //10

    public GameManager gM;
    
    
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other) //kates script
    {
        
        if (other.tag == "Stanley")
        {
            if (gM.timesRestarted < 1)
            {
                other.GetComponent<AudioSource>().PlayOneShot(b1_0);
            }
            else
            {
                float random = Random.Range(0.0f, 10.0f);
                if (random < 3.0f)
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_0);
                }else if (random < 5.0f)
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_1);
                }else if (random < 5.5f)
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_2);
                }else if (random < 6.5f)
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_3);
                }else if (random < 7.5f)
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_4);
                }else if (random < 8.0f)
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_5);
                }else if (random < 9.0f)
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_6);
                }else
                {
                    other.GetComponent<AudioSource>().PlayOneShot(b1_7);
                }
            }
            Destroy(this.gameObject);
        }
    }
}

