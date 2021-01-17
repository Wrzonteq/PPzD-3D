using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AudioZone : MonoBehaviour
{
    private new Collider collider;

    [SerializeField] AudioAmbience Ambience;

    void OnEnable()
    {
        collider = GetComponent<Collider>();
        collider.isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) AudioSystem.Instance.CurrentAmbience = Ambience;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") 
            && AudioSystem.Instance.CurrentAmbience != Ambience) AudioSystem.Instance.CurrentAmbience = Ambience;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) AudioSystem.Instance.CurrentAmbience = AudioSystem.Instance.DefaultAmbience;
    }
    
}
