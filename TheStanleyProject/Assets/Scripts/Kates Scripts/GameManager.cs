using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isMoving = false;

    public bool paused = false;

    public int timesRestarted = 0;

    public bool paperOrdered = false;

    public bool askedForGreg = false;

    public bool isGreg = false;

    //public GameObject askGregPanel;

    public bool leftOffice;

    public bool inBreakRoom;

    public bool pastTwoDoors;

    public bool wentLeft;

    public float mouseSensitivity = 1;

   
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MasterOffice");
        }

        
    }

    void AskForGreg()
    {
        //askGregPanel.SetActive(true);
    }

    void ItIsGreg()
    {
        isGreg = true;
    }

    void ItsNotGreg()
    {
        //askGregPanel.SetActive(false);
    }

    void Restart()
    {
        
    }
}
