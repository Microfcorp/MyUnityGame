using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class AIprovod : MonoBehaviour {

	public GameObject text;
	private bool go;
	public int maxprn;
	public int curprn;
	public int urr;
	private NavMeshAgent nma;
	public Transform goting;
	public AudioClip aud;
	public AudioSource aus;
	private int raz;
	public AI ai;

	// Use this for initialization
	void Start () {
		nma = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (missing.modex == 2) {
			if (go) {
				aus.PlayOneShot(aud);
				missing.modex = 3;
			}
		}
		if (missing.modex == 3) {
			if (go) {
				text.SetActive(true);
				if(Input.GetKeyDown (KeyCode.B)){
					if(curprn == maxprn){missing.modex = 4; text.SetActive(false);}
					else{curprn += 25;}
				}
			}
			else{text.SetActive(false);}
		}
		if (missing.modex == 4) {
			if(this.transform.position == goting.position){
				missing.modex = 5;
			}
			if (go) {
				nma.SetDestination (goting.position);							
			}
			else{}
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			go = true;
		}
		if (other.tag == "AI") {
			ai = other.GetComponent<AI>();
			ai.curHealth -= urr;
		}
		
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			go = false;
		}
	}
}
