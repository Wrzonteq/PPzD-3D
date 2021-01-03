using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour {
    [SerializeField] Animator animator;
    [SerializeField] UnityEvent onDoorOpen = new UnityEvent();
    [SerializeField] UnityEvent onDoorClose = new UnityEvent();
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] clips;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Player entered the door trigger");
            animator.SetBool("character_nearby", true);
            onDoorOpen.Invoke();
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Player left the door trigger");
            animator.SetBool("character_nearby", false);
            onDoorClose.Invoke();
        }
    }

    public void PlayDoorSound() 
    {
        if (animator.GetBool("character_nearby"))
        {
            audioSource.PlayOneShot(clips[0]);
        } else 
        {
            audioSource.PlayOneShot(clips[1]);
        }
    }
}
