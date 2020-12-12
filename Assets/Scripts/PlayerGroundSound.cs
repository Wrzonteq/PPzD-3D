using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerGroundSound : MonoBehaviour
{
    [SerializeField] private FirstPersonController firstPersonController;
    [SerializeField] private AudioSource stepsAudioSource;
    [SerializeField] private float dirtVolume;
    [SerializeField] private float metalVolume;
    
    [SerializeField] private AudioClip[] dirtWalkClips;
    [SerializeField] private AudioClip[] dirtRunClips;
    [Space]
    [SerializeField] private AudioClip[] metalWalkClips;
    [SerializeField] private AudioClip[] metalRunClips;

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, -transform.up, out var hit))
        {
            var hitObject = hit.collider.gameObject;
            if (hitObject)
            {
                var isGround = hitObject.CompareTag("Ground");
                firstPersonController.m_FootstepSounds = isGround ? dirtWalkClips : metalWalkClips;
                firstPersonController.runningFootsteps = isGround ? dirtRunClips : metalRunClips;

                stepsAudioSource.volume = isGround ? dirtVolume : metalVolume;
            }
        }
    }
}
