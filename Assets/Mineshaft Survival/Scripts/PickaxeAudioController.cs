using UnityEngine;

public class PickaxeAudioController : MonoBehaviour {
    [SerializeField] ObjectUsage objectUsage;
    [SerializeField] AudioSource inventory;
    [SerializeField] AudioClip pickaxeHitAudioSource;
    [SerializeField] AudioClip pickaxeWallHitAudioSource;
    private void Start() {
        inventory.bypassReverbZones = true;
        objectUsage.pickaxeHit.AddListener(() => inventory.PlayOneShot(pickaxeHitAudioSource));
        objectUsage.pickaxeWallHit.AddListener(() => inventory.PlayOneShot(pickaxeWallHitAudioSource));
    }
}
