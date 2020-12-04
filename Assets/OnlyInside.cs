using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyInside : MonoBehaviour
{
   public GameObject inTheBuildCheck;

   public void Update()
   {
      outside();
   }

   void outside()
   {
      
      inTheBuild inTheBuild = inTheBuildCheck.GetComponent<inTheBuild>();
      bool inside = inTheBuild.inSide;
      if (inside == false)
      {
         gameObject.GetComponent<AudioSource>().Pause();
      }
      else
      {
         gameObject.GetComponent<AudioSource>().UnPause();
      }
   }
}

