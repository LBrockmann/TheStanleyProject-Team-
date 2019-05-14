using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene_Lin : MonoBehaviour
{
    // Start is called before the first frame update
 public void ChangeScene()
    {
        SceneManager.LoadScene("MasterOffice");

    }
 
 //added another button function
 public void Quit()
    {
        Application.Quit();
    }
}
