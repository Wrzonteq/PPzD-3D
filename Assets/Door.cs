using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour {
    [SerializeField] Animator animator;
    [SerializeField] UnityEvent onDoorOpen = new UnityEvent();
    [SerializeField] UnityEvent onDoorClose = new UnityEvent();
    [SerializeField] AudioSource audio_door_open;
    [SerializeField] AudioSource audio_door_close;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", true);
            onDoorOpen.Invoke();
            audio_door_open.Play();
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", false);
            onDoorClose.Invoke();
            audio_door_close.Play();
        }
    }
}
