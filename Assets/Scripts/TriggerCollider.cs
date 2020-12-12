using UnityEngine;
using UnityEngine.Events;

public class TriggerCollider : MonoBehaviour
{
    public event UnityAction<TriggerCollider, bool> OnTriggerChanged;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnTriggerChanged?.Invoke(this, true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnTriggerChanged?.Invoke(this, false);
        }
    }
}
