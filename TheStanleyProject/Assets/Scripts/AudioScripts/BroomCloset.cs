using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BroomCloset : MonoBehaviour
{
    private bool _Audioplayed1;
    private bool _Audioplayed2;
    private bool _Audioplayed3;
    private bool _Audioplayed4;
    private bool _Audioplayed5;
    private bool _Audioplayed6;
    private bool _Audioplayed7;
    private bool _Audioplayed8;
    private bool _Audioplayed9;
    private bool _Audioplayed10;
    private bool _Audioplayed11;
    public AudioClip audioFile1;
    public AudioClip audioFile2;
    public AudioClip audioFile3;
    public AudioClip audioFile4;
    public AudioClip audioFile5;
    public AudioClip audioFile6;
    public AudioClip audioFile7;
    public AudioClip audioFile8;
    public AudioClip audioFile9;
    public AudioClip audioFile10;
    public AudioClip audioFile11;
    public float timerCap1;
    public float timerCap2;
    public float timerCap3;
    public float timerCap4;
    public float timerCap5;
    public float timerCap6;
    public float timerCap7;
    public float timerCap8;
    public float timerCap9;
    public float timerCap10;
    public float timerCap11;
    public float standStillTimer;
    public GameObject stanley;
    
    public GameManager gM;
    public Achievement aM;
    
    public float seconds = 1.0f;

    public bool stuckInCloset = false;
    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
         
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
        if (standStillTimer > timerCap6)
        {
            if (_Audioplayed6 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile6;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed6 = true;
            }
        }
        if (standStillTimer > timerCap7)
        {
            if (_Audioplayed7 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile7;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed7 = true;
            }
        }
        if (standStillTimer > timerCap8)
        {
            if (_Audioplayed8 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile8;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed8 = true;
            }
        }
        if (standStillTimer > timerCap9)
        {
            if (_Audioplayed9 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile9;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed9 = true;
            }
        }
        if (standStillTimer > timerCap10)
        {
            if (_Audioplayed10 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile10;
                stanley.GetComponent<AudioSource>().Play();
                _Audioplayed10 = true;
            }
        }
        if (standStillTimer > timerCap11)
        {
            if (_Audioplayed11 == false)
            {
                stanley.GetComponent<AudioSource>().Pause();
                stanley.GetComponent<AudioSource>().clip = audioFile11;
                stanley.GetComponent<AudioSource>().Play();
                aM.Activate(aM.deathBroomCloset);
                StartCoroutine(Restart());
                _Audioplayed11 = true;
            }
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stanley")
        {
            standStillTimer = standStillTimer + 1 * Time.deltaTime;
        }

        gM.inCloset = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Stanley")
        {
            standStillTimer = 0;
        }

        gM.inCloset = false;
    }
    
    IEnumerator Restart()
    { 
        yield return new WaitForSeconds(seconds);
        
        gM.RestartLevel();
        SceneManager.LoadScene("MasterOffice");
    }
}
