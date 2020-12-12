using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RatAudioController : MonoBehaviour
{
    [SerializeField] AudioSource ratIDLESource;
    [SerializeField] private List<AudioClip> ratIDLEAudio = new List<AudioClip>();

    [SerializeField] AudioSource ratAttackSource;
    [SerializeField] private List<AudioClip> ratAttackAudio = new List<AudioClip>();

    [SerializeField] AudioSource ratDeathSource;

    private void Start()
    {
        GameEvents.soundEvent.onRatIDLE += OnRatIDLE;
        GameEvents.soundEvent.onRatAttack += OnRatAttack;
        GameEvents.soundEvent.onPickaxeHitAI += OnRatAttack;
        GameEvents.soundEvent.onRatDeath += OnRatDeath;
    }


    void OnRatIDLE()
    {
        int index = (int)Random.Range(0, ratIDLEAudio.Count);
        ratIDLESource.PlayOneShot(ratIDLEAudio[index]);
    }

    void OnRatAttack()
    {
        int index = (int)Random.Range(0, ratAttackAudio.Count);
        ratAttackSource.PlayOneShot(ratAttackAudio[index]);
    }
    void OnRatDeath()
    {
        ratDeathSource.Play();
    }

    private void OnDestroy()
    {
        GameEvents.soundEvent.onRatIDLE -= OnRatIDLE;
        GameEvents.soundEvent.onRatAttack -= OnRatAttack;
        GameEvents.soundEvent.onRatDeath -= OnRatDeath;
    }
}

