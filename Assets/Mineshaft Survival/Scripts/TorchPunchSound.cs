using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TorchPunchSound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;
    [SerializeField] AudioMixerSnapshot defaultTorch;
    [SerializeField] AudioMixerSnapshot swungTorch;
    

    void ModifyTorchSound() 
    {
        Invoke("SwapToSwung", 0.0f);
        
        ChooseRandomSwingSound();

        Invoke("SwapToDefault", 0.4f);
    }

    void SwapToDefault() 
    {
        defaultTorch.TransitionTo(0.5f);
    }

    void SwapToSwung() 
    {
         swungTorch.TransitionTo(0.5f);
    }

    void ChooseRandomSwingSound() 
    {
        AudioClip placeholder;

        int n = Random.Range(1, audioClips.Length);
        placeholder = audioClips[n];
        audioSource.PlayOneShot(placeholder);
        audioClips[n] = audioClips[0];
        audioClips[0] = placeholder;
    }
}
