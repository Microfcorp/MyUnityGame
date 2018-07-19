using UnityEngine;  
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class kill : MonoBehaviour {

	public CharacterController chr;
	public GameObject player;
	public int kil = 0;

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		if(kil == 1){chr.enabled = false;
		
		}

	}

	public void Menu(){
		Application.LoadLevel (0);
	}

	public void Resp(){
		Application.LoadLevel (1);
	}
}
