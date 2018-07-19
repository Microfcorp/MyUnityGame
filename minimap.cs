using UnityEngine;
using System.Collections;

public class minimap : MonoBehaviour {

	public GameObject MiniMap;
	public bool map;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.M)) {
			map = !map;
		}
		if (map) {
			MiniMap.SetActive(false);
		}
		else{
			MiniMap.SetActive(true);
		}
	}
}
