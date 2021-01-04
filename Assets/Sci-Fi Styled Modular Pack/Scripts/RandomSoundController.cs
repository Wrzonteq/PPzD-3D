using System.Collections;
using UnityEngine;

public class RandomSoundController : MonoBehaviour
{
    [SerializeField] AudioClip[] clips;
    [SerializeField] AudioSource audioSource;

    [SerializeField] float interval;
    [SerializeField] int rangeMax;

    private IEnumerator coroutine;

    private void Start()
    {
        coroutine = Randomize(interval);
        StartCoroutine(coroutine);
    }

    private void PlayClip()
    {
        int n = Random.Range(1, clips.Length);
        audioSource.clip = clips[n];
        audioSource.PlayOneShot(audioSource.clip);
        clips[n] = clips[0];
        clips[0] = audioSource.clip;
    }

    private IEnumerator Randomize(float t) 
    {
        while (true) 
        {
            yield return new WaitForSeconds(t);

            int i = Random.Range(1, rangeMax);

            if (i == 1)
            {
                PlayClip();
            }
        }
    }
}
