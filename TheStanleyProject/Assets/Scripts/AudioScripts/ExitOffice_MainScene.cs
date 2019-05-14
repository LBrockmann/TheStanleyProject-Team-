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

    public AudioClip b2;
    
    public float seconds = 1.0f;

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
        other.GetComponent<AudioSource>().Pause();
        
        if (other.tag == "Stanley")
        {
            if (gM.timesRestarted < 1)
            {
                other.GetComponent<AudioSource>().clip = b1_0;
                other.GetComponent<AudioSource>().Play();
                GoToMetting(other);

            }
            else
            {
                float random = Random.Range(0.0f, 10.0f);
                if (random < 3.0f)
                {
                    other.GetComponent<AudioSource>().clip = b1_0;
                    other.GetComponent<AudioSource>().Play();
                    GoToMetting(other);
                }else if (random < 5.0f)
                {
                    other.GetComponent<AudioSource>().clip = b1_1;
                    other.GetComponent<AudioSource>().Play();
                }else if (random < 5.5f)
                {
                    other.GetComponent<AudioSource>().clip = b1_2;
                    other.GetComponent<AudioSource>().Play();
                }else if (random < 6.5f)
                {
                    other.GetComponent<AudioSource>().clip = b1_3;
                    other.GetComponent<AudioSource>().Play();
                }else if (random < 7.5f)
                {
                    other.GetComponent<AudioSource>().clip = b1_4;
                    other.GetComponent<AudioSource>().Play();
                }else if (random < 8.0f)
                {
                    other.GetComponent<AudioSource>().clip = b1_5;
                    other.GetComponent<AudioSource>().Play();
                }else if (random < 9.0f)
                {
                    other.GetComponent<AudioSource>().clip = b1_6;
                    other.GetComponent<AudioSource>().Play();
                }else
                {
                    other.GetComponent<AudioSource>().clip = b1_7;
                    other.GetComponent<AudioSource>().Play();
                }
            }
            Destroy(this.gameObject);
        }
    }


    IEnumerator GoToMetting(Collider other)
    {
        yield return new WaitForSeconds(seconds);
        print("b2");
        other.GetComponent<AudioSource>().clip = b2;
        other.GetComponent<AudioSource>().Play();
    }
}

