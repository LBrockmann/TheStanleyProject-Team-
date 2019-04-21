using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement: MonoBehaviour
{
    public Image achievementNoti;
    public Text bigText;
    public Text smallTest;

    public Sprite placeHolder;
    public Sprite pic1;
    public Sprite pic2;

    public int notiTimer = 1000;
    public int timer = 0;

    public Raycast rC;
    
    public class Achievements
    {
        public bool achieved;
        public string notiText;
        public string notiSmallText;
        public int activation;

        public int picNumber;

        public Achievements(string noti, string noti2, int pic)
        {
            achieved = false;
            notiText = noti;
            activation = 0;
            notiSmallText = noti2;

            picNumber = pic;


        }

    }

    public Achievements jump = new Achievements("You cant jump","no seriously we never added that",1);
    public Achievements random = new Achievements("Youre Lucky", "you did nothing to get this",2);


    private void Start()
    {
        achievementNoti.gameObject.SetActive(false);
        float i = Random.Range(0.0f, 1.0f);
        if (i > .5)
        {
           Activate(random);
        }
        
    }

    void Update()
    {
        //reset timer
        if (timer > notiTimer)
        {
            Reset();
            timer = 0;
        }
        else
        {
            timer += 1;
        }
        //jump achievement
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!jump.achieved)
            {
                jump.activation += 1; 
            }
        }

        if (!jump.achieved && jump.activation > 2)
        {
            Activate(jump);
        }
    }

    void Reset()
    {
        achievementNoti.gameObject.SetActive(false);
        bigText.gameObject.SetActive(false);
        smallTest.gameObject.SetActive(false);
    }

    public void Activate(Achievements a)
    {
        timer = 0;
        achievementNoti.gameObject.SetActive(true);
        bigText.gameObject.SetActive(true);
        smallTest.gameObject.SetActive(true);

        if (a.picNumber == 1)
        {
            achievementNoti.sprite = pic1;
        }if (a.picNumber == 2)
        {
            achievementNoti.sprite = pic2;
        }
        else
        {
            achievementNoti.sprite = placeHolder;
        }

        bigText.text = a.notiText;
        smallTest.text = a.notiSmallText;

        a.achieved = true;

    }
   
    
}
