using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;

public class audio : MonoBehaviour {

	public AudioSource music1;
	public AudioSource music2;
	public AudioSource music3;
	public AudioSource music4;
	public AudioSource sound1;
	public AudioSource sound2;
	public AudioSource sound3;
	public AudioSource sound4;
	int music;
	int sound;
	//public List<AudioClip> audiosmusic = new List<AudioClip>();
	// Use this for initialization
	void Start () {
					
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void setMusic(){
		music1.volume = settingmeny.music;
		music2.volume = settingmeny.music;
		music3.volume = settingmeny.music;
		music4.volume = settingmeny.music;
	}

	public void setSound(){
		sound1.volume = settingmeny.music;
		sound2.volume = settingmeny.music;
		sound3.volume = settingmeny.music;
		sound4.volume = settingmeny.music;
	}
}
