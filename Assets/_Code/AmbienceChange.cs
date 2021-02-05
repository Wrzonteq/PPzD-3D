using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AmbienceChange : MonoBehaviour
{
    [SerializeField] AudioMixerSnapshot outside;
    [SerializeField] AudioMixerSnapshot inside;
    [SerializeField] bool insides = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && insides)
        {
            inside.TransitionTo(0.5f);
        }
        if (other.gameObject.CompareTag("Player") && !insides)
        {
            outside.TransitionTo(0.5f);
        }
    }
}
