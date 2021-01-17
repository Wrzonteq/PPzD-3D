using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSystem : MonoBehaviour
{
    public AudioAmbience CurrentAmbience;
    public AudioAmbience DefaultAmbience;


    #region Singleton implementation

    private static AudioSystem instance;
    public static AudioSystem Instance
    {
        get
        {
            return instance ?? new AudioSystem();
        }
        set
        {
            instance = value;
        }
    }

    void OnEnable()
    {
        instance = this;
    }

    void OnDisable()
    {
        if (this == instance) instance = null;
    }

    #endregion
}
