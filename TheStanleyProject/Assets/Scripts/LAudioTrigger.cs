using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAudioTrigger : MonoBehaviour
{

    public GameObject Stanley;

    public AudioClip What;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Stanley")
        {
            Stanley.GetComponent<AudioSource>().PlayOneShot(What);
            Debug.Log("play: " + Stanley.GetComponent<AudioSource>().clip + Time.time);
            Destroy(this.gameObject);
        }
    }
}
