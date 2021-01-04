using UnityEngine;
using UnityEngine.Audio;

public class InteriorChecker : MonoBehaviour
{
    [SerializeField] AudioMixerSnapshot interior;
    [SerializeField] AudioMixerSnapshot exterior;

    private float interval = 0.5f;
    private float counter = 0;

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.tag == "Player")
        {
            counter++;

            interior.TransitionTo(interval);
        }
    }

    private void OnTriggerExit(Collider other)
    {
    

        if (other.tag == "Player")
        {
            counter--;

            if (counter == 0)
            {
                exterior.TransitionTo(interval);
            }
        }
    }
}
