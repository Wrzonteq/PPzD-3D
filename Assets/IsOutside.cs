using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOutside : MonoBehaviour
{
 
    void OnTriggerEnter(Collider other)
    {
        GameObject.Find("inTheBuildCheck").GetComponent<inTheBuild>().inSide = false;
    }
}
