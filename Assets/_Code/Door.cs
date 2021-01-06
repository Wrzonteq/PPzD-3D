using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class Door : MonoBehaviour {
    [SerializeField] Animator animator;
    [SerializeField] UnityEvent onDoorOpen = new UnityEvent();
    [SerializeField] UnityEvent onDoorClose = new UnityEvent();
    [SerializeField] private AudioSource doorSource;
    [SerializeField] private AudioClip doorOpen;
    [SerializeField] private AudioClip doorClose;


    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", true);
            onDoorOpen.Invoke();
            doorSource.PlayOneShot(doorOpen);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", false);
            onDoorClose.Invoke();
            doorSource.PlayOneShot(doorClose);
        }
    }
}
