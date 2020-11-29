using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
class AudioAmbienceItem : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioAmbience audioAmbience;

    bool setted = true;

    float SettedVolume;

    void Awake()
    {
        if (audioSource == null) audioSource = GetComponent<AudioSource>();
        if (audioAmbience == null) audioAmbience = AudioSystem.Instance.DefaultAmbience;
        SettedVolume = audioSource.volume;
    }

    void FixedUpdate()
    {
        if (audioAmbience != AudioSystem.Instance.CurrentAmbience)
        {
            if (setted)
            {
                StopAllCoroutines();
                StartCoroutine(SlowlyChangeVolume(5, 0.1f, 0));
                setted = false;
            }
        }
        else
        {
            if (!setted)
            {
                StopAllCoroutines();
                StartCoroutine(SlowlyChangeVolume(5, 0.1f, SettedVolume));
                setted = true;
            }
        }
    }

    IEnumerator SlowlyChangeVolume(float time, float step, float volume)
    {
        var temp = 0f;
        while (temp < time)
        {
            yield return new WaitForSeconds(step);
            temp += Time.deltaTime + step;
            audioSource.volume = Mathf.Lerp(audioSource.volume, volume, temp / time);
        }
        yield return new WaitForEndOfFrame();
    }

}