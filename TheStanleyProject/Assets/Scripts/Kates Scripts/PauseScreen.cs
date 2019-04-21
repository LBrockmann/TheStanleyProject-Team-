using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool paused;

    void Start()
    {
        pauseScreen.SetActive(false);
        paused = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (paused)
            {
                UnPause();
            }
            else
            {
                Pause(); 
            }
            
            
        }
    }

    public void Pause()
    {
        pauseScreen.SetActive(true);
        paused = true;
    }

    public void UnPause()
    {
        pauseScreen.SetActive(false);
        paused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("MasterOffice");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
