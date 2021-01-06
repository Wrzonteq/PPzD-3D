using UnityEngine;
using UnityEngine.Audio;

public class InsideOutsideCheck : MonoBehaviour
{
    [SerializeField] private AudioMixerSnapshot insideSound;
    [SerializeField] private AudioMixerSnapshot outsideSound;
    private const float transitionDuration = .5f;
    
    void OnTriggerEnter(Collider other) {
        insideSound.TransitionTo(transitionDuration);
    }

    void OnTriggerExit(Collider other) {
        outsideSound.TransitionTo(transitionDuration);
    }
}
