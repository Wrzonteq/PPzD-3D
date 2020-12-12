using UnityEngine;
using Random = UnityEngine.Random;

public class RandomClipWithDelay : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] possibleClips;
    [SerializeField] private Vector2 minMaxDelay;
    [SerializeField] private Vector2 minMaxVolume;

    private void Awake()
    {
        Invoke(nameof(PlayRandomClip), Random.Range(minMaxDelay.x, minMaxDelay.y));
    }

    private void PlayRandomClip()
    {
        audioSource.PlayOneShot(GetRandomClip(), Random.Range(minMaxVolume.x, minMaxVolume.y));
        Invoke(nameof(PlayRandomClip), Random.Range(minMaxDelay.x, minMaxDelay.y));
    }

    private AudioClip GetRandomClip()
    {
        return possibleClips[Random.Range(0, possibleClips.Length)];
    }
}
