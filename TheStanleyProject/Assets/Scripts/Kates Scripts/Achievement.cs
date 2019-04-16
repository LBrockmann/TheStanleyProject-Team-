using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement: MonoBehaviour
{
    public Image achievementNoti;

    public Sprite placeHolder;

    public int notiTimer = 100;
    public int timer = 0;
    
    public class Achievements
    {
        public bool achieved;
        public Sprite notiPicture;
        public string notiText;
        public int activation;

        public Achievements(string noti, Sprite notiP)
        {
            achieved = false;
            notiPicture = notiP;
            notiText = noti;
            activation = 0;

        }

        public void Activate()
        {
            //achievementNoti.gameObject.SetActive(true);
            //achievementNoti.sprite = notiPicture;
            achieved = true;
        }
    }

    //public Achievements jump = new Achievements("Jump 3 Times", placeHolder);
    //public Achievements random = new Achievements("Youre Lucky", placeHolder);


    private void Start()
    {
        achievementNoti.gameObject.SetActive(false);
        int i = Random.Range(0, 1);
        if (i > .5)
        {
           // random.Activate();
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
           // if (!jump.achieved)
            //{
           //     jump.activation += 1; 
           // }
        }

        //if (!jump.achieved && jump.activation > 2)
        //{
        //    jump.Activate();
       // }
    }

    void Reset()
    {
        //achievementNoti.gameObject.SetActive(false);
    }
   
    
}
