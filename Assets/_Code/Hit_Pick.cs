using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Pick : MonoBehaviour
{
    [SerializeField] private AudioSource src;

    public void PlayAudioOneShot()
    {
        src.PlayOneShot(src.clip);
    }
}
