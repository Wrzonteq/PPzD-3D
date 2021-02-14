using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VcaSetup : MonoBehaviour
{
    public string vca1;
    public string vca2;
    public float volume1;
    public float volume2;

    // Start is called before the first frame update
    void Start()
    {
        RuntimeManager.GetVCA(vca1).setVolume(volume1);
        RuntimeManager.GetVCA(vca2).setVolume(volume2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
