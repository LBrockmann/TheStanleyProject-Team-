using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{

    private bool S1loaded, S2loaded, S3loaded, S4loaded;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator newScene(int MenuLoadPercent)
    {
        //MenuLoadPercent = (int)Random.Range(1, 100);

        if (MenuLoadPercent >= 1 && MenuLoadPercent < 25 && S1loaded == false)
        {
            //load scene possibility 1
            S1loaded = true;
        }
        else if (S1loaded)
        {
            StartCoroutine(newScene((int) Random.Range(1, 100)));
        }
        

        if (MenuLoadPercent >= 25 && MenuLoadPercent < 50 && S2loaded == false)
        {
            //load scene 2
            S2loaded = true;
        }
        else if (S2loaded)
        {
            StartCoroutine(newScene((int) Random.Range(1, 100)));
        }
        

        if (MenuLoadPercent >= 50 && MenuLoadPercent < 75 && S3loaded == false)
        {
            //load scene 3
            S3loaded = true;
        }
        else if (S3loaded)
        {
            StartCoroutine(newScene((int) Random.Range(1, 100)));
        }
        

        if (MenuLoadPercent >= 75 && MenuLoadPercent < 101 && S4loaded == false)
        {
            S4loaded = true;
        }
        else if (S4loaded)
        {
            StartCoroutine(newScene((int) Random.Range(1, 100)));
        }


        return null;
        //How can I set this so it'll load the master office rather than return null
    }
}


