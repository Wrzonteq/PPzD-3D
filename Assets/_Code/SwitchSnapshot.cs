using FMODUnity;
using UnityEngine;
using UnityEngine.Audio;

public class SwitchSnapshot : MonoBehaviour
{

    public string vca1;
    public string vca2;
    public float volume1;
    public float volume2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            RuntimeManager.GetVCA(vca1).setVolume(volume1);
            RuntimeManager.GetVCA(vca2).setVolume(volume2);
        }
    }
}
