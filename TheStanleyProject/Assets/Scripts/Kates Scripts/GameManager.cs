using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isMoving = false;

    public bool paused = false;
    
    public bool stayOffice;
    public bool inVoid;
    public bool inCloset;
    public bool inBreakRoom;

    public bool diedInBroomCloset;
    public bool diedInOffice;
    public bool diedinWarehouse;
    public bool diedinVoid;
    
    

   
    //to edit moues sense

    public static float mouseSensitivity = 1;
    
    
    //scene loading manager
    public int timesRestarted = 0;
    public bool paperOrdered = false;
    public bool phoneCall = false;
    public bool phoneAnswered = false;
    public bool paperReceived = false;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MasterOffice");
        }


        
    }

    

    public void RestartLevel()
    {
        stayOffice = false;
        paused = false;
        inVoid = false;
        inCloset = false;
        inBreakRoom = false;
        timesRestarted += 1;
    }

    public void GameReset()
    {
        RestartLevel();
        timesRestarted = 0;
        diedinVoid = false;
        diedinWarehouse = false;
        diedInOffice = false;
        diedInBroomCloset = false;
        phoneCall = false;
        paperReceived = false;
        phoneAnswered = false;
        paperOrdered = false;
    }
    public void AdjustMouse(float newMouseSen)
    {
        mouseSensitivity = newMouseSen;
    }

}
