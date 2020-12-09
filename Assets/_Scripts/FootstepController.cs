using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FootstepController : MonoBehaviour
{
    private Ray ray;
    [SerializeField] private AudioClip[] outsideFootsteps;
    [SerializeField] private AudioClip[] outsideRunningFootsteps;
    [SerializeField] private AudioClip[] insideFootstep;
    [SerializeField] private AudioClip[] insideRunningFootstep;

    private FirstPersonController fpsController;
    private void Start()
    {
        fpsController = GetComponent<FirstPersonController>();
    }

    private void Update()
    {
        ray = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 2.0f))
        {
            if (hit.transform.CompareTag("Ground"))
            {
                fpsController.runningFootsteps = outsideRunningFootsteps;
                fpsController.m_FootstepSounds = outsideFootsteps;
            }
            else
            {
                fpsController.runningFootsteps = insideRunningFootstep;
                fpsController.m_FootstepSounds = insideFootstep;
            }
        }
    }
}
