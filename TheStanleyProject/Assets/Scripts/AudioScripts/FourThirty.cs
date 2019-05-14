using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourThirty : MonoBehaviour
{
    public AudioClip audioclip1;
    public AudioClip audioclip2;
    public AudioClip audioclip3;
    public AudioClip audioclip4;
    public AudioClip audioclip5;
    public AudioClip audioclip6;
    public AudioClip audioclip7;
    public AudioClip audioclip8;
    public AudioClip audioclip9;
    public AudioClip audioclip10;
    public AudioClip audioclip11;
    public AudioClip audioclip12;
    public bool clip1played;
    public bool clip2played;
    public bool clip3played;
    public bool clip4played;
    public bool clip5played;
    public bool clip6played;
    public bool clip7played;
    public bool clip8played;
    public bool clip9played;
    public bool clip10played;
    public bool clip11played;
    public bool clip12played;

    public AudioSource aS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAudioClipOne()
    {
        if (!clip1played)
        {
            print("a1");
            aS.Pause();
            aS.clip = audioclip1;
            aS.Play();
        }
    }
    
    public void playAudioClipTwo()
    {
        if (!clip2played)
        {
            print("a2");
            aS.Pause();
            aS.clip = audioclip2;
            aS.Play();
        }
    }
    
    public void playAudioClipThree()
    {
        if (!clip3played)
        {
            print("a3");
            aS.Pause();
            aS.clip = audioclip3;
            aS.Play();
        }
    }
    
    public void playAudioClipFour()
    {
        if (!clip4played)
        {
            print("a4");
            aS.Pause();
            aS.clip = audioclip4;
            aS.Play();
        }
    }
    
    public void playAudioClipFive()
    {
        if (!clip5played)
        {
            aS.Pause();
            aS.clip = audioclip5;
            aS.Play();
        }
    }
    
    public void playAudioClipSix()
    {
        if (!clip6played)
        {
            aS.Pause();
            aS.clip = audioclip6;
            aS.Play();
        }
    }
    
    public void playAudioClipSeven()
    {
        if (!clip7played)
        {
            aS.Pause();
            aS.clip = audioclip7;
            aS.Play();
        }
    }
    
    public void playAudioClipEight()
    {
        if (!clip8played)
        {
            aS.Pause();
            aS.clip = audioclip8;
            aS.Play();
        }
    }
    
    public void playAudioClipNine()
    {
        if (!clip9played)
        {
            aS.Pause();
            aS.clip = audioclip9;
            aS.Play();
        }
    }
    
    public void playAudioClipTen()
    {
        if (!clip10played)
        {
            aS.Pause();
            aS.clip = audioclip10;
            aS.Play();
        }
    }
    
    public void playAudioClipEle()
    {
        if (!clip11played)
        {
            aS.Pause();
            aS.clip = audioclip11;
            aS.Play();
        }
    }
    
    public void playAudioClipTwe()
    {
        if (!clip12played)
        {
            aS.Pause();
            aS.clip = audioclip12;
            aS.Play();
        }
    }
}
