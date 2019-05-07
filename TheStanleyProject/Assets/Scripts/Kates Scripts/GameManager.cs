using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isMoving = false;

    public bool paused = false;
    
    public bool leftOffice;
    
    

   
    //to edit moues sense

    public float mouseSensitivity = 1;
    
    
    //scene loading manager
    public int timesRestarted = 0;
    public bool paperOrdered = false;
    public bool phoneCall = false;
    public bool phoneAnswered = false;
    public bool paperReceived = false;

   
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

    

    void Restart()
    {
        
    }
}
