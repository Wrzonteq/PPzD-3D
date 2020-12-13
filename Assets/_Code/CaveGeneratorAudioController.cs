using UnityEngine;

public class CaveGeneratorAudioController : MonoBehaviour {
    [SerializeField] AudioSource generatorAudioSource;
    [SerializeField] Generator generator;

    void Update() {
        generatorAudioSource.volume = generator.Toggled ? 1f : 0f;
    }
}