using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AudioController : MonoBehaviour
{
    private bool isInside = false;
    [SerializeField] private GameObject outsideAudio;
    [SerializeField] private GameObject insideAudio;
    
    private void Start()
    {
        outsideAudio.SetActive(true);
        insideAudio.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInside = !isInside;
            Debug.Log($"Player inside: {isInside}");
            if (isInside)
            {
                outsideAudio.SetActive(false);
                insideAudio.SetActive(true);
            }
            else
            {
                outsideAudio.SetActive(true);
                insideAudio.SetActive(false);
            }
        }
    }

    public void PlayAudioOneShot(AudioSource audioSrc)
    {
        audioSrc.PlayOneShot(audioSrc.clip);
    }
    
}
