using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class meny : MonoBehaviour {
	public GameObject settings;
	public AudioSource audio;
	public Toggle touble1;
	public Toggle touble2;

	public void Newgame () {
		Application.LoadLevel(1);
	}
	public void Loadgame () {
		
	}
	public void Setting () {
		settings.SetActive(!settings.activeSelf);
	}
	public void Exit () {
		Application.Quit();
	}
	public void setMusic(float value){
		settingmeny.music = value;
		audio.volume = settingmeny.music;
		//Debug.Log(value);
	}
	public void setSound(float value){
		settingmeny.sound = value;
	}
	public void setslozn(bool value){

	}
	public void slozof () {
		settingmeny.slozn = true;
		
		Debug.Log(settingmeny.slozn);
	}
	public void slozoff () {
		settingmeny.slozn = false;
		
		Debug.Log(settingmeny.slozn);
	}
}
