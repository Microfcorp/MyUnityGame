using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int ur;
	public GameObject Bulet;
	private AI ai;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){ 
		if (other.tag == "Ign") {
			return;
		} else if (other.name == "Player") {
			Destroy (Bulet.gameObject);

		} else if (other.tag == "AI") {	
			ai = other.GetComponent<AI> ();
			ai.curHealth -= ur;
			Destroy (Bulet.gameObject);
		} else if (other.tag == "cub") {
			Destroy (Bulet.gameObject);
		} else {
			Destroy (Bulet.gameObject);
		}
	}
	
	void OnTriggerExit(Collider other){ 
		if (other.name == "Player") {
			

		}
		
	}
}
