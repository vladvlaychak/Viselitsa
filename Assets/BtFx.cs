using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtFx : MonoBehaviour {
	public AudioSource MyFx;
	public AudioClip howerfx;
	public AudioClip clikfx;

  public void howersound()
	{
		MyFx.PlayOneShot(howerfx);
	}
	public void cliksound()
	{
		MyFx.PlayOneShot(clikfx);
	}
}
