using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassPanelWithDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Animator>().SetBool("character_nearby", true);
            GetComponent<StudioEventEmitter>().Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Animator>().SetBool("character_nearby", false);
            GetComponent<StudioEventEmitter>().Play();
        }
    }
}
