using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class projectorScript : MonoBehaviour
{
    [SerializeField] AudioClip GlobeAppearSound;
    [SerializeField] AudioClip GlobeHideSound;
    [SerializeField] AudioSource audioSource;

    [SerializeField] UnityEvent onGlobeAppear= new UnityEvent();
    [SerializeField] UnityEvent onGlobeHide = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onGlobeAppear.Invoke();
            if (audioSource == null)
            {
                audioSource = GetComponent<AudioSource>();
            }
            if (GlobeAppearSound != null)
            {
                audioSource.clip = GlobeAppearSound;
                audioSource.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onGlobeHide.Invoke();
            if (audioSource == null)
            {
                audioSource = GetComponent<AudioSource>();
            }
            if (GlobeHideSound != null)
            {
                audioSource.clip = GlobeHideSound;
                audioSource.Play();
            }  
        }
    }
}
