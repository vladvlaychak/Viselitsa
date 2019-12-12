using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour {

	public GameObject settings;
	public GameObject help;
	public void StartGame()
	 {
		 Application.LoadLevel(1);
	 }
	public void LoadGame()
	{

	}
	public void Settings()
	{
		settings.SetActive(!settings.activeSelf);
	}
	public void Help()
	{
		help.SetActive(!help.activeSelf);
	}
	public void Quit()
	{
	Application.Quit();
	}
	public void setMusic(float value)
	{
		Global.music = value;
	}
	public void setSound(float value)
	{
		Global.sound = value;
	}
}
