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
    public AudioClip clickingSound1;
    public AudioClip clickingSound2;
    public AudioClip doorjiggle;
    private bool _audioPlayed;


    public Achievement aM;
    public int doorFourThirtyClicks = 0;
    public int doorFourSeventeenClicks = 0;
    public int doorFourThirtySevenClicks = 0;
    public int doorFourNineteenClicks = 0;
    public int doorFourSixteenClicks = 0;
    public int doorFourFifteenClicks = 0;
    public int copierClicks = 0;

    public GameManager gM;

    public BroomCloset bC1;
    public BroomCloset bC2;

    public FourThirty fT;

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

                
                if (hit.transform.tag == "Door" || hit.transform.tag == "Door430" || hit.transform.tag == "Door417" || hit.transform.tag == "Door437"
                     || hit.transform.tag == "Door416" || hit.transform.tag == "OfficeDoor" || hit.transform.tag == "Door415") //kate added these doors for the 430 acheivemnt
                {
                    print("hit door");
                    stanleyObject.GetComponent<AudioSource>().PlayOneShot(doorjiggle);
                }
                else
                {
                    clicking();
                    _clickCount++;
                }

                if (hit.transform.tag == "VoidDoor")
                {
                    hit.transform.GetComponentInParent<DoorManager>().openDoor(); 
                    gM.inVoid = true;
                }
                
                if (hit.transform.tag == "ClosetDoor" && !bC1.stuckInCloset && !bC2.stuckInCloset && !gM.diedInBroomCloset)
                {

                        if (hit.transform.GetComponentInParent<DoorManager>().open)
                        {
                            hit.transform.GetComponentInParent<DoorManager>().closeDoor();
                        }
                        else
                        {
                            hit.transform.GetComponentInParent<DoorManager>().openDoor();
                        }
                }
                
                if (hit.transform.tag == "Door430")
                {
                    print("Door 430");
                    doorFourThirtyClicks += 1;
                    if (doorFourThirtyClicks > 4 && aM.fourThirty.activation == 0)
                    {  
                        if (stanleyObject.GetComponent<AudioSource>().isPlaying) ///this isnt working to keep it from interrupting, idk why so i have it set to true
                        {
                            aM.fourThirty.activation = 1;
                            doorFourThirtyClicks = 0;
                            fT.playAudioClipOne();
                            //print("audio should play");
                        }
                        doorFourThirtyClicks = 0;
                    }
                    else if (doorFourThirtyClicks > 19 && aM.fourThirty.activation == 1)
                    {
                        aM.fourThirty.activation = 2;
                        doorFourThirtyClicks = 0;
                        fT.playAudioClipTwo();
                    }
                    else if (doorFourThirtyClicks > 49 && aM.fourThirty.activation == 2)
                    {
                        aM.fourThirty.activation = 3;
                        doorFourThirtyClicks = 0;
                        fT.playAudioClipThree();
                    } else if (doorFourThirtyClicks > 4 && aM.fourThirty.activation == 11)
                    {
                        aM.fourThirty.activation = 12;
                        doorFourThirtyClicks = 0;
                        fT.playAudioClipTwe();
                        aM.Activate(aM.fourThirty);
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
                        fT.playAudioClipFour();
                    }
                    if (doorFourSeventeenClicks > 0 && aM.fourThirty.activation == 8)
                    {
                        aM.fourThirty.activation = 9;
                        doorFourSeventeenClicks = 0;
                        fT.playAudioClipNine();
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
                        fT.playAudioClipFive();
                    }

                    if (doorFourThirtySevenClicks > 0 && aM.fourThirty.activation == 6)
                    {
                        aM.fourThirty.activation = 7;
                        doorFourThirtySevenClicks = 0;
                        fT.playAudioClipSeven();
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
                        fT.playAudioClipSix();
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
                        fT.playAudioClipTen();
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
                        fT.playAudioClipEight();
                    }
                    if (copierClicks > 0 && aM.fourThirty.activation == 10)
                    {
                        aM.fourThirty.activation = 11;
                        copierClicks = 0;
                        fT.playAudioClipEle();
                    }
                }

                else if (hit.transform.tag == "OfficeDoor")
                {
                    hit.transform.GetComponentInParent<DoorManager>().closeDoor();     //this lets stanley stay in his office - kate
                    print("officeDoor");
                    gM.stayOffice = true;
                }
                else
                {
                    
                }
                
            }
            
        }

        if (_timer > 30)
        {
            _timer = 0;
            _clickCount = 0;
        }

        if (_clickCount >= clickCap)
        {
            if (_audioPlayed == false && !stanleyObject.GetComponent<AudioSource>().isPlaying && !gM.inCloset && !gM.stayOffice && !gM.inVoid)
            {
                stanleyObject.GetComponent<AudioSource>().PlayOneShot(clickAudioClip);
                _audioPlayed = true;
            }

            _clickCount = 0;

        }
        
        
        _timer = _timer + 1 * Time.deltaTime;
    }
    private void clicking()
    {
        int x = Random.Range(0, 10);

        if (!stanleyObject.GetComponent<AudioSource>().isPlaying)
        {
            if (x < 5)
            {
                stanleyObject.GetComponent<AudioSource>().clip = clickingSound1;
                stanleyObject.GetComponent<AudioSource>().Play();
            }
            else
            {
                stanleyObject.GetComponent<AudioSource>().clip = clickingSound2;
                stanleyObject.GetComponent<AudioSource>().Play();
            } 
        }

        
    }
    
    
}