using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit: MonoBehaviour
{
    [SerializeField] AudioSource src;

    public void PlayAudioOneShot()
    {
        src.PlayOneShot(src.clip);
    }
}
