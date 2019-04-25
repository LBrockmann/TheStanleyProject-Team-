using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool isMoving = false;

    public int timesRestarted = 0;

    public bool paperOrdered = false;

    public bool askedForGreg = false;

    public bool isGreg = false;

    public GameObject askGregPanel;

    public bool leftOffice;

    public bool inBreakRoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AskForGreg()
    {
        askGregPanel.SetActive(true);
    }

    void ItIsGreg()
    {
        isGreg = true;
    }

    void ItsNotGreg()
    {
        askGregPanel.SetActive(false);
    }
}
