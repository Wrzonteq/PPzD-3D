using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    [SerializeField] ObjectUsage usage;
    [SerializeField] AudioSource inventory;
    [SerializeField] AudioClip punchTorch;
    private void Start()
    {
        usage.PunchTorch.AddListener(() => inventory.PlayOneShot(punchTorch));
    }
}
