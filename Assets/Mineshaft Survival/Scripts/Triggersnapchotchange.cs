using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggersnapchotchange : MonoBehaviour
{
    public string increaseVCA;
    public string decreaseVCA;
    private void OnTriggerEnter(Collider other)
    {
       RuntimeManager.GetVCA(decreaseVCA).setVolume(0);
       RuntimeManager.GetVCA(increaseVCA).setVolume(1);
    }
}
