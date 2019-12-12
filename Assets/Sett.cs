using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sett : MonoBehaviour {
	public GameObject seting;
	public void Settings()
	{
		seting.SetActive(!seting.activeSelf);
	}
	public void Quit()
	{
	  Application.LoadLevel(0);	
	}
}
