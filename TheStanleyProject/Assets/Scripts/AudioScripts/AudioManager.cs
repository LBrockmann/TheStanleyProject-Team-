using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //kates script
    public GameManager gM;
    
    //audio clips
    public AudioClip standStill;
    
    //functions
    public void StandStill()
    {
        if (!gM.isMoving && !gM.inBreakRoom) 
        {
            
        }
    }
}
