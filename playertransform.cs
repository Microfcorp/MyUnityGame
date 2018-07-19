using UnityEngine;
using System.Collections;

public class playertransform : MonoBehaviour {

	public HP hp;
	public GameObject player;
	public GameObject fonar;
	public GameObject craft;
	public GameObject menu;
	//public GameObject pist;
	public GameObject mis;
	public AI ai;
	private int gofonar = 0;
	private int gosvet = 0;
	private static float y;
	public bool cr;
	public bool me;

	public GameObject[] enemies;



	void Start () {
		mis.SetActive(false);
	}

	private void Change(bool status){
		this.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = status;
	}

	// Update is called once per frame
	void Update () {

		y = player.transform.position.y;

		if (y < -25) {
			hp.curHealth -= 90;
			player.transform.position = new Vector3 (164, 5, 156);
		}

//		if (Input.GetKeyDown (KeyCode.F)) { // при нажатии на tab наш инвентарь будет открываться и закрываться
//			if (gofonar == 0) {
//				fonar.SetActive (true);
//				gofonar = 1;
//			} else {
//				fonar.SetActive (false);
//				gofonar = 0;
//			}
//		}
		if (Input.GetKeyDown (KeyCode.C)) { // при нажатии на tab наш инвентарь будет открываться и закрываться
			cr = !cr;

			if (cr) {
				craft.SetActive (true);
				Change(false);
			} else {
				craft.SetActive (false);
				Change(true);
			}

		}
		if (Input.GetKeyDown (KeyCode.Escape)) { // при нажатии на tab наш инвентарь будет открываться и закрываться
			me = !me;
			
			if (me) {
				menu.SetActive (true);
				Change(false);
			} else {
				menu.SetActive (false);
				Change(true);
			}
			
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			mis.SetActive(!mis.activeSelf);
		}

		if (ai == null) {
		//	ai = enemies;
		}
		enemies = GameObject.FindGameObjectsWithTag("AI");
		//Debug.Log (enemies);
	
	}	

	void OnTriggerEnter (Collider other) {  

	}

}
