using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour {
    [SerializeField] Animator animator;
    [SerializeField] UnityEvent onDoorOpen = new UnityEvent();
    [SerializeField] UnityEvent onDoorClosing = new UnityEvent();
    [SerializeField] UnityEvent onDoorClosed = new UnityEvent();

    private AudioSource audiosource;
    [SerializeField] AudioClip doorOpen;
    [SerializeField] AudioClip doorClose;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", true);
            onDoorOpen.Invoke();
            audiosource.PlayOneShot(doorOpen);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            animator.SetBool("character_nearby", false);
            onDoorClosing.Invoke();
            audiosource.PlayOneShot(doorClose);
        }
    }

    void DoorClosed()
    {
        onDoorClosed.Invoke();
    }
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
}
