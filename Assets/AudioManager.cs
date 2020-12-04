using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;

    [SerializeField] UnityEvent SwitchToInsideAmbient;
    [SerializeField] UnityEvent SwitchOutsideAmbient;

    bool player_inside = false;
    bool inside_check = false;

    public void PlayerEnter(bool enter)
    {
        inside_check = enter;
    }

    public void DoorOpen(bool open)
    {
        
        //player inside, door closed -> player inside
        if (!open && inside_check)
        {
            player_inside = true;
        }
        //player outside, door closed -> player outside
        //player inside OR outside, door open -> count as outside (opening door = you are outside)
        if ((!open && !inside_check) || (player_inside && open))
        {
            player_inside = false;
        }
    }

    public void DoorClosed()
    {
        if (player_inside)
            SwitchToInsideAmbient.Invoke();
        else
            SwitchOutsideAmbient.Invoke();
    }

}
