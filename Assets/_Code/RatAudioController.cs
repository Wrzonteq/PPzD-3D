using UnityEngine;

public class RatAudioController : MonoBehaviour {
    [SerializeField] AIController ratAIController;
    [SerializeField] AudioSource ratAudio;
    [SerializeField] AudioSource ratDeathAudio;

    bool ratDeathWasHandled;
    void Update() {
        if (ratDeathWasHandled == false && ratAIController.Health <= 0) {
            ratDeathWasHandled = true;
            ratDeathAudio.Play();
            ratAudio.volume = 0f;
        }
    }
}
