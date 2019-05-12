using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISound_Lin : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource ad;
    public AudioClip Hover1;
    public AudioClip Hover2;
    public AudioClip Click1;
    public void Start()
    {
        ad = GameObject.Find("Canvas").GetComponent<AudioSource>();
      
    }
    public void playHoverSound() {
        int x = Random.Range(0, 10);

        if (x < 5)
        {
            ad.PlayOneShot(Hover1);
        }
        else
        {
            ad.PlayOneShot(Hover2);
        }

    }
    public void click()
    {
        ad.PlayOneShot(Click1);
    }
}
