﻿using UnityEngine;
using System.Collections;

public class outhouse : MonoBehaviour {
	
	//public GameObject door;
	public string player;
	public GameObject Player;
	public GameObject Spawn;
	public AudioClip Sounds;
	public AudioSource audio;
	private static float x;
	private static float y;
	private static float z;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider door) 
	{
		if (door.gameObject.name == player)
		{
			audio.PlayOneShot(Sounds);
			x = Spawn.transform.position.x;
			y = Spawn.transform.position.y;
			z = Spawn.transform.position.z;
			Player.transform.position = new Vector3 (x, y, z);
		}
	}
}