using UnityEngine;
using UnityEngine.Audio;

public class SwitchSnapshot : MonoBehaviour
{

    public AudioMixerSnapshot snapshot;
    public bool echo;
    public float time;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            snapshot.TransitionTo(time);
            other.GetComponent<AudioSource>().bypassReverbZones = echo;
        }
    }
}
