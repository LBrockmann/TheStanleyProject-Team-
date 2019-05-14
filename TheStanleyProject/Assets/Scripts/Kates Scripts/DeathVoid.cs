using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathVoid : MonoBehaviour
{
    public Achievement aM;
    
    public GameManager gM;

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
            aM.Activate(aM.deathVoid);
            gM.diedinVoid = true;
            activated = true;
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(seconds);
        
        gM.RestartLevel();
        SceneManager.LoadScene("MasterOffice");
    }
}
