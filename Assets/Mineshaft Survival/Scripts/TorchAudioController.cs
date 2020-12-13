using UnityEngine;
using UnityEngine.Assertions;

public class TorchAudioController : MonoBehaviour {
    [SerializeField] ObjectUsage objectUsage;
    [SerializeField] AudioSource inventory;
    [SerializeField] AudioClip hitAudioClip;
    private void Start() {
        Assert.IsTrue(hitAudioClip != null);
        objectUsage.torchHit.AddListener(() => inventory.PlayOneShot(hitAudioClip));
    }
}
