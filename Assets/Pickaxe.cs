using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : MonoBehaviour
{
    [SerializeField] ObjectUsage usage;
    [SerializeField] AudioSource inventory;
    [SerializeField] AudioClip pickaxePunch;
    [SerializeField] AudioClip pickaxeHit;
    private void Start()
    {
        usage.PunchPickAxe.AddListener(() => inventory.PlayOneShot(pickaxePunch));
        usage.HitPickAxe.AddListener(() => inventory.PlayOneShot(pickaxeHit));
    }
}
