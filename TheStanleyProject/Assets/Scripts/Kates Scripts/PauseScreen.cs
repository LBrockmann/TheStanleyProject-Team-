﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool paused;
    public GameManager gM;

    public GameObject stanley;
    
    public Achievement aM;

    void Start()
    {
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        pauseScreen.SetActive(false);
        paused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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

        if (paused)
        {
            stanley.GetComponentInChildren<SimpleSmoothMouseLook>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            stanley.GetComponent<CharacterMovement2>().enabled = false;
            stanley.GetComponent<AudioSource>().Pause();
        }
        else
        {
            stanley.GetComponentInChildren<SimpleSmoothMouseLook>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            stanley.GetComponent<CharacterMovement2>().enabled = true;
        }
    }

    public void Pause()
    {
        pauseScreen.SetActive(true);
        paused = true;
        gM.paused = true;
    }

    public void UnPause()
    {
        pauseScreen.SetActive(false);
        paused = false;
        gM.paused = false;
    }

    public void Restart()
    {
        gM.RestartLevel();
        SceneManager.LoadScene("MasterOffice");
        
    }

    public void LoadMenu()
    {
        
        aM.GameReset();
        gM.GameReset();
        SceneManager.LoadScene("MenuScene");
    }
}
