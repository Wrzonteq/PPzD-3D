using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwitch : MonoBehaviour
{
    [SerializeField] AudioSource[] sources_outside;
    [SerializeField] AudioSource[] sources_laboratory;

    float volumeChangeRate = 0.0025f;

    bool isOutside = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOutside)
        {
            foreach (AudioSource audioSource in sources_outside)
            {
                audioSource.volume += volumeChangeRate;
            }

            foreach (AudioSource audioSource in sources_laboratory)
            {
                audioSource.volume -= volumeChangeRate;
            }
        }
        else
        {
            foreach (AudioSource audioSource in sources_outside)
            {
                audioSource.volume -= volumeChangeRate;
            }

            foreach (AudioSource audioSource in sources_laboratory)
            {
                audioSource.volume += volumeChangeRate;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        isOutside = false;
    }

    void OnTriggerExit(Collider other)
    {
        isOutside = true;
    }
}
