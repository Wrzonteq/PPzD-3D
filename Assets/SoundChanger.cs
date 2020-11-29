using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundChanger : MonoBehaviour
{

	public AudioSource ambientPlayer;
	public AudioClip outsideAmbient;
	public AudioClip insideAmbient;

	public int triggerCounter = 0;
	private void OnTriggerEnter(Collider other)
	{
		triggerCounter++;
		if (other.tag == "Inside" && triggerCounter == 1)
		{
			ambientPlayer.clip = insideAmbient;
			ambientPlayer.Play();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		triggerCounter--;
		if (other.tag == "Inside" && triggerCounter == 0)
		{
			ambientPlayer.clip = outsideAmbient;
			ambientPlayer.Play();
		}
	}
}
