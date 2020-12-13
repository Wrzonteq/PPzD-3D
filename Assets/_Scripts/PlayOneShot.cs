using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOneShot : MonoBehaviour
{
    [SerializeField] private AudioSource src;
    
    public void PlayAudioOneShot()
    {
        src.PlayOneShot(src.clip);
    }
}
