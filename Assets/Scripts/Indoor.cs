using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Indoor : MonoBehaviour
{
    [SerializeField] FirstPersonController player;
    [SerializeField] AudioSource ambience;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.ChangeActiveFootsteps(EnvironmentalState.indoor);
            ambience.spatialBlend = 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.ChangeActiveFootsteps(EnvironmentalState.outdoor);
            ambience.spatialBlend = 0;
        }
    }
}
