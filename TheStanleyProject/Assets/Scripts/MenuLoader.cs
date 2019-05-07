using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    public GameManager gM;

    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        gM.paperOrdered = true;
        StartCoroutine(newScene(66));
        print("loading dem scenes");
        
        //scenes 
        
        //main scene - 30
        //flip - 20
        //paper - 15
        //phone = 10
        //blue - 5
        //bluehall - 10
        //hall - 10
        
        
        //package - 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator newScene(float MenuLoadPercent)
    {
        //MenuLoadPercent = (float)Random.Range(0.0f, 100.0f);

        if (gM.paperOrdered && !gM.paperReceived)
        {
            gM.paperReceived = true;
            SceneManager.LoadScene("Package");
        }else if (MenuLoadPercent < 30)
        {
            //stay in main scene
        }
        else if (MenuLoadPercent < 50)
        {
            SceneManager.LoadScene("Flip");
        }
        else if (MenuLoadPercent < 65)
        {
            SceneManager.LoadScene("Paper");
        }
        else if (MenuLoadPercent < 75)
        {
            if (!gM.phoneCall)
            {
                SceneManager.LoadScene("Phone");
            }
        }
        else if (MenuLoadPercent < 80)
        {
            SceneManager.LoadScene("Blue");   
        }else if (MenuLoadPercent < 90)
        {
            SceneManager.LoadScene("BlueHall");   
        }else
        {
            SceneManager.LoadScene("Hall");   
        }


        return null;
        //How can I set this so it'll load the master office rather than return null
    }
}


