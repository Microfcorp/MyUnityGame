using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Wind : MonoBehaviour {

	public WindZone directwind;
	public WindZone wind1;
	public WindZone wind2;
	public WindZone wind3;
	public WindZone wind4;
	public int rand;
	public float t;
	public float tim = 15f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//directwind.

		if (Time.time - t > tim) { // алгоритм задержки между отниманием жизней 
			rand = Random.Range(1,6);
			switch (rand) {
			case 1:
				directwind.gameObject.SetActive (true);
				break;
			case 2:
				directwind.gameObject.SetActive (false);
				break;
			case 3:
				wind1.radius = 80;
				wind2.radius = 80;
				wind3.radius = 80;
				wind4.radius = 80;
				wind1.gameObject.SetActive(true);
				wind2.gameObject.SetActive(false);
				wind3.gameObject.SetActive(false);
				wind4.gameObject.SetActive(false);
				break;
			case 4:
				wind1.radius = 90;
				wind2.radius = 90;
				wind3.radius = 90;
				wind4.radius = 90;
				wind1.gameObject.SetActive(false);
				wind2.gameObject.SetActive(true);
				wind3.gameObject.SetActive(false);
				wind4.gameObject.SetActive(false);
				break;
			case 5:
				wind1.radius = 70;
				wind2.radius = 70;
				wind3.radius = 70;
				wind4.radius = 70;
				wind1.gameObject.SetActive(false);
				wind2.gameObject.SetActive(false);
				wind3.gameObject.SetActive(true);
				wind4.gameObject.SetActive(false);
				break;
			case 6:
				wind1.radius = 90;
				wind2.radius = 80;
				wind3.radius = 70;
				wind4.radius = 100;
				wind1.gameObject.SetActive(false);
				wind2.gameObject.SetActive(false);
				wind3.gameObject.SetActive(false);
				wind4.gameObject.SetActive(true);
				break;
				
			}
			t = Time.time; // завершение задержки 
		}

	}
}
