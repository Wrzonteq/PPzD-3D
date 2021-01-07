using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InsideAudio : MonoBehaviour
{
    [SerializeField] AudioMixerSnapshot Outside;
    [SerializeField] AudioMixerSnapshot Inside;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Room")
        {
            Outside.TransitionTo(1);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Room")
        {
            Inside.TransitionTo(1);
        }
    }
}
