using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField, EventRef] string onInteraction;
    [SerializeField] bool hasReturnInteraction;
    [SerializeField, EventRef] string onReturnInteraction;

    EventInstance eventInstance;
    private void Awake()
    {
        RuntimeManager.GetEventDescription(onInteraction).loadSampleData();
        if (hasReturnInteraction) {
            RuntimeManager.GetEventDescription(onReturnInteraction).loadSampleData();
        }
    }

    void OnDestroy() {
        RuntimeManager.GetEventDescription(onInteraction).unloadSampleData();
        if (hasReturnInteraction)
        {
            RuntimeManager.GetEventDescription(onReturnInteraction).unloadSampleData();
        }
    }


}
