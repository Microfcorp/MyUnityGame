using UnityEngine;
using System.Collections;

public class minimeny : MonoBehaviour {

	public GameObject men;
	public GameObject sett;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play () {
		men.SetActive(!men.activeSelf);
	}
	public void Newgame () {
		Application.LoadLevel (1);
	}
	public void Setting () {
		sett.SetActive(!sett.activeSelf);
	}
	public void Exit () {
		Application.LoadLevel (0);
	}
}
