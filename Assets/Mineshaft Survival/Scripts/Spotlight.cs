using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight : MonoBehaviour {

    [Header("Spotlight stats")]
    public float MaxDistance = 20;
    public bool Toggled = true;
    [Header("Light Objects")]
    public Renderer lightCube;
    public GameObject Lights;
    [Header("Materials")]
    public Material LampOn;
    public Material LampOff;
    [Header("ID")]
    string SpotID;

    public float distance;

    public GameObject generator;

    [Header("Audio Settings")]
    public AudioClip spotlightFailureClip;
    public AudioClip spotlightTurnOnClip;
    public AudioClip spotlightTurnOffClip;
    public AudioClip spotlightBuzzClip;
    AudioSource audioSource;
    AudioSource instancerSource;

    public void Toggle()
    {
        if(generator.GetComponent<Generator>().Toggled == false) 
        {
            audioSource.PlayOneShot(spotlightFailureClip);
        } else 
        {
            if(Toggled) 
            {
                instancerSource.PlayOneShot(spotlightTurnOffClip);
                audioSource.clip = null;
            } else 
            {
                instancerSource.PlayOneShot(spotlightTurnOnClip);
                audioSource.clip = spotlightBuzzClip;
                audioSource.Play();
            }
        }
            
        Toggled = !Toggled;
    }


    public void Start()
    {
        SpotID = GetInstanceID().ToString() + "SPOTLIGHT";
        audioSource = GetComponent<AudioSource>();
        instancerSource = GameObject.FindWithTag("Instancer").GetComponent<AudioSource>();
        Load();
    }

    public void Update()
    {
        generator = GameObject.FindGameObjectWithTag("Generator");
        distance = Vector3.Distance(gameObject.transform.position, generator.transform.position);

        if (distance <= MaxDistance && Toggled == true && generator.GetComponent<Generator>().Toggled == true)
        {
            lightCube.material = LampOn;
            Lights.SetActive(true);
        }
        else
        {
            Toggled = false;
        }
        if(Toggled == false)
        {
            lightCube.material = LampOff;
            Lights.SetActive(false);
            audioSource.clip = null;
        }
    }

    public void Save()
    {
        if(Toggled)
        {
            PlayerPrefs.SetInt(SpotID, 1);
        }
        else
        {
            PlayerPrefs.SetInt(SpotID, 0);
        }
    }
    public void Load()
    {
        if(PlayerPrefs.GetInt(SpotID) == 1)
        {
            Toggled = true;
            audioSource.clip = spotlightBuzzClip;
            audioSource.Play();
        }
        else
        {          
            Toggled = false;
            audioSource.clip = null;
        }
    }
}
