using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

   
public class inTheBuild : MonoBehaviour
{
   public void Update()
   {
      setSfxLvl();
   }
   public bool inSide = false;
   void OnTriggerEnter(Collider other)
   {
      if (inSide == false)
         inSide = true;
      else
      {
         inSide = false;
      }
      
   }

   [SerializeField] private AudioMixer sfx;
    
   void setSfxLvl()
   {
      if (inSide)
      {
         sfx.SetFloat("windSound" , -20f);
      }
      else
      {
         sfx.SetFloat("windSound", 0f);
      }
   }
 

}
