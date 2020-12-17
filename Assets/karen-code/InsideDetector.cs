using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class InsideDetector : MonoBehaviour
{
[SerializeField] AudioMixerSnapshot Outside;
[SerializeField] AudioMixerSnapshot Inside;
[SerializeField] AudioSource DoorOpen;
[SerializeField] AudioSource DoorClose;
string currentStatus = "outside";

        void OnTriggerStay(Collider other)
    {
        Debug.Log("inside");
        currentStatus = "inside";
    }

        void OnTriggerExit(Collider other)
    {
        Debug.Log("outside");
        currentStatus = "outside";
    }

      void changeSnapshot() {
    if (currentStatus == "outside") {
      Outside.TransitionTo(0.01f);
      DoorClose.Play(0);
    }
     
     if (currentStatus == "inside") {
      Inside.TransitionTo(0.01f);
      DoorOpen.Play(0);
    }

  }

  void Update() {
    changeSnapshot();
  }

}
