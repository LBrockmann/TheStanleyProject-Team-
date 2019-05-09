using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool paused;
    public GameManager gM;

    public GameObject stanley;

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
            stanley.GetComponent<CharacterMovement2>().enabled = false;
        }
        else
        {
            stanley.GetComponentInChildren<SimpleSmoothMouseLook>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
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
        SceneManager.LoadScene("MasterOffice");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
