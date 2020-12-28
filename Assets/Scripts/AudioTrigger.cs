using UnityEngine;
using UnityEngine.Audio;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    public bool isTriggeringInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isTriggeringInside)
            {
                _audioMixer.FindSnapshot("Inside").TransitionTo(1f);
            }
            else
            {
                _audioMixer.FindSnapshot("Outside").TransitionTo(1f);
            }
        }
    }
}
