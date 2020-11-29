using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AudioZone : MonoBehaviour
{
    private new Collider collider;

    void OnEnable()
    {
        collider = GetComponent<Collider>();
        collider.isTrigger = true;
    }

    void OnTriggerEnter()
    {
        
    }

    void OnTriggerExit()
    {
        
    }
}
