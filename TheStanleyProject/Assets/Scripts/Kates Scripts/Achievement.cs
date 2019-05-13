using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Achievement: MonoBehaviour
{
    public Image achievementNoti;
    public Text bigText;
    public Text smallTest;

    public Sprite placeHolder;
    
    public Sprite jumpPic; //1
    public Sprite luckyPic;//2
    public Sprite sodaPic;//3
    public Sprite gregPic;//4
    public Sprite trophyPic;//5
    public Sprite deathPic;//6
    public Sprite fourThirtyPic;//7
    
    
    //endings list
    //u never listened
    //u went up stairs
    //u went down stairs
    //u never left ur room
    //u stayed in the broom closet

    public int notiTimer = 1000;
    public int timer = 0;

    public Raycast rC;

    public GameManager gM;

    public PauseScreen pS;
    
    //greg manager

    public bool askedForGreg = false;

    public bool isGreg = false;

    public GameObject askGregPanel;
    
    //achiement array
    
    public Achievements[] allofThem = new Achievements[9];
    
    //singleton managment
    
    private static Achievement _instance;

    public static Achievement Instance
    
    {
        get { return _instance; }
    }
    
    //win managment
    public float seconds = 1.0f;
    
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

    public Achievements jump = new Achievements("You cant jump","No seriously we never added that",1);
    public Achievements random = new Achievements("Youre Lucky", "You did nothing to get this",2);
    public Achievements greg = new Achievements("You are Greg", "Greg Stanley Heffernan",4);
    public Achievements trophy = new Achievements("You beat this game", "But you lost The Game",5);
    public Achievements deathWarehouse = new Achievements("You Died", "This is what happens when u dont listen",6);
    public Achievements deathVoid = new Achievements("You Died", "This is what happens when u listen",6);
    public Achievements deathBroomCloset = new Achievements("You Died", "You married the broom and lived happily ever after until you starved to death",6);
    public Achievements deathOffice = new Achievements("You Died", "The whole point of this game is to leave the office and you ruined it",6);
    public Achievements fourThirty = new Achievements("You did it?", "That was a complete waste of time",7);
    
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }

    private void Start()
    {
        //game manager assignment
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        
        //random acheivement
        achievementNoti.gameObject.SetActive(false);
        float i = Random.Range(0.0f, 1.0f);
        if (i > .5)
        {
           Activate(random);
        }
        
        Reset();
        
        DontDestroyOnLoad(this.gameObject);

        allofThem[0] = jump;
        allofThem[1] = random;
        allofThem[2] = greg;
        allofThem[3] = trophy;
        allofThem[4] = deathWarehouse;
        allofThem[5] = deathVoid;
        allofThem[6] = deathBroomCloset;
        allofThem[7] = deathOffice;
        allofThem[8] = fourThirty;
    }

    void Update()
    {
        if (gM.timesRestarted < 1 && !askedForGreg)
        {
            //AskForGreg();
        }
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
        
        //soda achievement
       
        
        //greg achievement
        if (isGreg)
        {
            Activate(greg);
        }
        //trophy achievment
        if (deathWarehouse.achieved && deathOffice.achieved && deathVoid.achieved && 
            deathBroomCloset.achieved)
        {
            StartCoroutine(Trophy());
        }
        //430 acheivement
        if (fourThirty.activation == 12)
        {
            Activate(fourThirty);
        }
        
    }

    void Reset()
    {
        achievementNoti.gameObject.SetActive(false);
        bigText.gameObject.SetActive(false);
        smallTest.gameObject.SetActive(false);
    }

    public void Activate(Achievements a)
    {                                                                  //you have to manually set all the pictures here it sucks!!!!!!!!
        timer = 0;
        achievementNoti.gameObject.SetActive(true);
        bigText.gameObject.SetActive(true);
        smallTest.gameObject.SetActive(true);

        if (a.picNumber == 1)
        {
            achievementNoti.sprite = jumpPic;
        }if (a.picNumber == 2)
        {
            achievementNoti.sprite = luckyPic;
        }if (a.picNumber == 3)
        {
            achievementNoti.sprite = sodaPic;
        }if (a.picNumber == 4)
        {
            achievementNoti.sprite = gregPic;
        }if (a.picNumber == 5)
        {
            achievementNoti.sprite = trophyPic;
        }if (a.picNumber == 6)
        {
            achievementNoti.sprite = deathPic;
        }if (a.picNumber == 7)
        {
            achievementNoti.sprite = fourThirtyPic;
        }
        else
        {
            achievementNoti.sprite = placeHolder;
        }

        bigText.text = a.notiText;
        smallTest.text = a.notiSmallText;

        a.achieved = true;
        

    }
    
    public void AskForGreg()
    {
        askGregPanel.SetActive(true);
        pS.paused = true;
        askedForGreg = true;
    }

    public void ItIsGreg()
    {
        isGreg = true;
        askGregPanel.SetActive(false);
        pS.paused = false;
    }

    public void ItsNotGreg()
    {
        askGregPanel.SetActive(false);
        pS.paused = false;
    }

    public void GameReset()
    {
        for (int i = 0; i < allofThem.Length; i++)
        {
            allofThem[i].achieved = false;
            allofThem[i].activation = 0;
        }
    }
   
    IEnumerator Trophy()
    {
        yield return new WaitForSeconds(seconds);
        
        Activate(trophy);
    }
}
