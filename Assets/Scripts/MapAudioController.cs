using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MapAudioController : MonoBehaviour
{
    [SerializeField] private List<TriggerCollider> innerTriggers;
    [SerializeField] private AudioMixerSnapshot insideSnapshot;
    [SerializeField] private AudioMixerSnapshot outsideSnapshot;

    private List<TriggerCollider> triggeredColliders = new List<TriggerCollider>();
    private bool isInside;
    
    private void Awake()
    {
        foreach (var triggerCollider in innerTriggers)
        {
            triggerCollider.OnTriggerChanged += TriggerColliderChanged;
        }
    }

    private void TriggerColliderChanged(TriggerCollider trigger, bool value)
    {
        if(value && !innerTriggers.Contains(trigger)) triggeredColliders.Add(trigger);
        else if (!value) innerTriggers.Remove(trigger);

        var inside = innerTriggers.Count > 0;
        if (isInside != inside)
        {
            isInside = inside;
            if(isInside) insideSnapshot.TransitionTo(.5f);
            else outsideSnapshot.TransitionTo(.5f);
        }
    }
}
