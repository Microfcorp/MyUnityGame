using UnityEngine;
using System.Collections;

public class lift : MonoBehaviour {

	public GameObject player;
	public GameObject conez;
	public CharacterController playerch;
	public bool go;
	private float t;
	private float tim = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (go) {
			playerch.enabled = false;
				player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + 1f, player.transform.position.z);
		} else {
			playerch.enabled = true;
		}

		if (player.transform.position.y >= conez.transform.position.y) {
			go = false;
		}

	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			go = true;
		}

	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			go = false;
		}
	}
}
