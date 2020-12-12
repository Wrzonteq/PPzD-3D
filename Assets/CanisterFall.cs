using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanisterFall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            if (this.tag == "OilBarrel")
                GameEvents.soundEvent.CanisterFall();
            else
                GameEvents.soundEvent.CanFall();

        }


    }
}
