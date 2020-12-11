using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AmbienceController : MonoBehaviour
{
    [SerializeField] private AudioMixer masterAudioMixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider trigger)
    {
        if(trigger.gameObject.tag == "Player")
        {
            masterAudioMixer.FindSnapshot("InLab").TransitionTo(1.5f);
        }
    }
    private void OnTriggerExit(Collider trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            masterAudioMixer.FindSnapshot("OutLab").TransitionTo(1.5f);
        }
    }
}
