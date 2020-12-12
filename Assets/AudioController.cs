using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioMixer caveAudioMixer;

    [SerializeField] AudioSource torchPunchSource;
    [SerializeField] AudioSource pickaxePunchSource;
    [SerializeField] AudioSource pickaxeImpactSource;
    [SerializeField] AudioSource pickaxeImpactAISource;

    [SerializeField] AudioSource canisterFallSource;
    [SerializeField] private List<AudioClip> canisterFallAudio = new List<AudioClip>();

    [SerializeField] AudioSource canFallSource;
    [SerializeField] private List<AudioClip> canFallAudio = new List<AudioClip>();

    [SerializeField] AudioSource lampIgniteSource;
    [SerializeField] AudioSource lampOutSource;
    [SerializeField] AudioSource liquidPourSource;

    [SerializeField] AudioSource generatorTurnOnSource;
    [SerializeField] GameObject generatorWorkingObject;


    private void Start()
    {
        GameEvents.soundEvent.onPickaxeHit += OnPickaxeHitSound;
        GameEvents.soundEvent.onPickaxeHitAI += OnPickaxeHitSoundAI;
        GameEvents.soundEvent.onCanisterFall += OnCanisterFallSound;
        GameEvents.soundEvent.onCanFall += OnCanFallSound;
        GameEvents.soundEvent.onLampIgnite += OnLampIgnite;
        GameEvents.soundEvent.onLampOut += OnLampOut;
        GameEvents.soundEvent.onLiquidPour += OnLiquidPour;
        GameEvents.soundEvent.onGeneratorSwitch += OnGeneratorSwitch;
        GameEvents.soundEvent.onGeneratorWorking += OnGeneratorWorking;
        GameEvents.soundEvent.onGeneratorNotWorking += OnGeneratorNotWorking;
    }

    private void OnPickaxeHitSound()
    {
        Invoke("PickaxeImpactSound", .4f);
    }
    private void OnPickaxeHitSoundAI()
    {
        Invoke("PickaxeImpactAISound", .4f);
    }


    void TorchPuchSound()
    {
        torchPunchSource.Play();
    }


    void PickAxePuchSound()
    {
        pickaxePunchSource.Play();
    }

    void PickaxeImpactSound()
    {
        pickaxeImpactSource.Play();
    }
    void PickaxeImpactAISound()
    {
        pickaxeImpactAISource.Play();
    }
    
    void OnCanisterFallSound()
    {
        int index = (int)Random.Range(0, canisterFallAudio.Count);
        canisterFallSource.PlayOneShot(canisterFallAudio[index]);
    }

    void OnCanFallSound()
    {
        int index = (int)Random.Range(0, canFallAudio.Count);
        canFallSource.PlayOneShot(canFallAudio[index]);
    }

    void OnLampIgnite()
    {
        lampIgniteSource.Play();
    }
    void OnLampOut()
    {
        lampOutSource.Play();
    }
    void OnLiquidPour()
    {
        liquidPourSource.Play();
    }
    void OnGeneratorSwitch()
    {
        generatorTurnOnSource.Play();
    }
    void OnGeneratorWorking()
    {
        generatorWorkingObject.SetActive(true);
        //generatorWorkingObject.Play();
        caveAudioMixer.FindSnapshot("GeneratorWorking").TransitionTo(2.5f);
    }
    void OnGeneratorNotWorking()
    {
        
        caveAudioMixer.FindSnapshot("Default").TransitionTo(1.5f);
        Invoke("GeneratorFadeOut", 2f);

    }

    void GeneratorFadeOut()
    {
        //generatorWorkingObject.Stop();
        generatorWorkingObject.SetActive(false);
    }
}


