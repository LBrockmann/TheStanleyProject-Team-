﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWareHouse : MonoBehaviour
{
    public Achievement aM;
    
    public GameManager gM;

    public float seconds1 = 1.0f;
    public float seconds = 1.0f;

    public bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
        
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Stanley" && !activated)
        {
            activated = true;
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(seconds1);
        
        aM.Activate(aM.deathWarehouse);
        gM.diedinWarehouse = true;
        
        yield return new WaitForSeconds(seconds);
        
        gM.RestartLevel();
        SceneManager.LoadScene("MasterOffice");
    }
}
