using UnityEngine;
using System.Collections;

public class cat : MonoBehaviour {

	public bool ca = false;
	public GameObject camerac;
	private static float xp = 164.8f;
	private static float yp = 1.6f;
	private static float zp = 156.8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (ca == true) {
			camerac.transform.position = new Vector3 (xp, yp, zp);
		}

	}
}
