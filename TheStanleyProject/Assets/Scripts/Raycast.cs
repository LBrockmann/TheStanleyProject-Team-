using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float rayDistance = 1f;
    public Camera stanley;
    public int _clickCount = 0;
    private float _timer;
    public int clickCap;
    public GameObject stanleyObject;
    public AudioClip clickAudioClip;
    private bool _audioPlayed;

    public bool sodaVended = false;

    public Achievement aM;
    public int doorFourThirtyClicks = 0;
    public int doorFourSeventeenClicks = 0;
    public int doorFourThirtySevenClicks = 0;
    public int doorFourNineteenClicks = 0;
    public int doorFourSixteenClicks = 0;
    public int doorFourFifteenClicks = 0;
    public int copierClicks = 0;

    public GameManager gM;

    void Start()
    {
        _audioPlayed = false;
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }
    void Update()
    {
        //Ray myRay = new Ray(transform.position, transform.forward);

        Debug.DrawRay(stanley.transform.position, stanley.transform.forward * rayDistance, Color.blue);
        
        RaycastHit hit;

        if (Physics.Raycast(stanley.transform.position, stanley.transform.forward, out hit, rayDistance))
        {
            //print(hit.transform.tag);
            if (Input.GetMouseButtonDown(0))
            {
                _clickCount++;
                if (hit.transform.tag == "Door" || hit.transform.tag == "Door430" || hit.transform.tag == "Door417" || hit.transform.tag == "Door437"
                    || hit.transform.tag == "Door419" || hit.transform.tag == "Door416" || hit.transform.tag == "OfficeDoor" || hit.transform.tag == "Door415") //kate added these doors for the 430 acheivemnt
                {
                    print("hit door");
                }
                if (hit.transform.tag == "Vending" && !sodaVended)
                {
                    print("get soda");
                    sodaVended = true;

                }
                if (hit.transform.tag == "Door430")
                {
                    print("Door 430");
                    doorFourThirtyClicks += 1;
                    if (doorFourThirtyClicks > 4 && aM.fourThirty.activation == 0)
                    {
                        aM.fourThirty.activation = 1;
                        doorFourThirtyClicks = 0;
                    }
                    else if (doorFourThirtyClicks > 19 && aM.fourThirty.activation == 1)
                    {
                        aM.fourThirty.activation = 2;
                        doorFourThirtyClicks = 0;
                    }
                    else if (doorFourThirtyClicks > 49 && aM.fourThirty.activation == 2)
                    {
                        aM.fourThirty.activation = 3;
                        doorFourThirtyClicks = 0;
                    } else if (doorFourThirtyClicks > 4 && aM.fourThirty.activation == 11)
                    {
                        aM.fourThirty.activation = 12;
                        doorFourThirtyClicks = 0;
                    } 
                }
                if (hit.transform.tag == "Door417")
                {
                    print("Door 417");
                    doorFourSeventeenClicks += 1;
                    if (doorFourSeventeenClicks > 19 && aM.fourThirty.activation == 3)
                    {
                        aM.fourThirty.activation = 4;
                        doorFourSeventeenClicks = 0;
                    }
                    if (doorFourSeventeenClicks > 0 && aM.fourThirty.activation == 8)
                    {
                        aM.fourThirty.activation = 9;
                        doorFourSeventeenClicks = 0;
                    }
                }
                if (hit.transform.tag == "Door437")
                {
                    print("Door 437");
                    doorFourThirtySevenClicks += 1;
                    if (doorFourThirtySevenClicks > 0 && aM.fourThirty.activation == 4)
                    {
                        aM.fourThirty.activation = 5;
                        doorFourThirtySevenClicks = 0;
                    }

                    if (doorFourThirtySevenClicks > 0 && aM.fourThirty.activation == 6)
                    {
                        aM.fourThirty.activation = 7;
                        doorFourThirtySevenClicks = 0;
                    }
                }
                if (hit.transform.tag == "Door415")
                {
                    print("Door 415");
                    doorFourFifteenClicks += 1;
                    if (doorFourFifteenClicks > 9 && aM.fourThirty.activation == 5)
                    {
                        aM.fourThirty.activation = 6;
                        doorFourFifteenClicks = 0;
                    }
                }
                if (hit.transform.tag == "Door416")
                {
                    print("Door 416");
                    doorFourSixteenClicks += 1;
                    if (doorFourSixteenClicks > 1 && aM.fourThirty.activation == 9)
                    {
                        aM.fourThirty.activation = 10;
                        doorFourSixteenClicks = 0;
                    }
                }
                if (hit.transform.tag == "Copier")
                {
                    print("Copier");
                    copierClicks += 1;
                    if (copierClicks > 0 && aM.fourThirty.activation == 7)
                    {
                        aM.fourThirty.activation = 8;
                        copierClicks = 0;
                    }
                    if (copierClicks > 0 && aM.fourThirty.activation == 10)
                    {
                        aM.fourThirty.activation = 11;
                        copierClicks = 0;
                    }
                }

                if (hit.transform.tag == "OfficeDoor" && !gM.leftOffice)
                {
                    hit.transform.GetComponent<DoorManager>().closeDoor();       //this lets stanley stay in his office - kate
                }
                
                
            }
            
        }

        if (_timer > 15)
        {
            _timer = 0;
            _clickCount = 0;
        }

        if (_clickCount >= clickCap)
        {
            if (_audioPlayed == false && stanleyObject.GetComponent<AudioSource>().isPlaying == false)
            {
                stanleyObject.GetComponent<AudioSource>().PlayOneShot(clickAudioClip);
                _audioPlayed = true;
            }
            
        }
        
        
        _timer = _timer + 1 * Time.deltaTime;
    }
}