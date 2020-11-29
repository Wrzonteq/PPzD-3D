using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip[] clips;

    public void OnEnable()
    {
        try
        {
            if (source == null) source = GetComponent<AudioSource>();
        }
        catch (ArgumentNullException e)
        {
            Debug.LogWarning($"{gameObject} has {e}");
        }
    }

    public void Play(int i)
    {
        try
        {
            source.PlayOneShot(clips[i]);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Debug.LogWarning($"{gameObject} has {e}");
        }
    }
}