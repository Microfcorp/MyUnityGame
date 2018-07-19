using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pistolet : MonoBehaviour {

	public Transform bullet;
	public string Spawn;
	public GameObject oruzie;
	public GameObject model;
	public GameObject pull;
	public Text ost;
	public Text vseg;
	public int BulletForce = 3000;
	public int Magaz = 7;
	public int maxmagaz = 7;
	public int vsep;
	public int t;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (oruzie.activeSelf == true) {
			pull.SetActive (true);
		} else {
			pull.SetActive(false);
		}

		int.TryParse(ost.text, out Magaz);
		int.TryParse(vseg.text, out vsep);
		//vseg.text = maxmagaz.ToString();

		if (Input.GetMouseButtonDown (0) & Magaz > 0) {
			Transform BulletInstance = (Transform) Instantiate (bullet, GameObject.Find (Spawn).transform.position, Quaternion.identity);
			BulletInstance.GetComponent<Rigidbody>().AddForce (transform.forward * BulletForce);
			Magaz -= 1;
			//Magaz -= 1;
			ost.text = Magaz.ToString();
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			if(vsep <= 0){
			}
			else{
				if(vsep >= maxmagaz){
					vsep -= (maxmagaz - Magaz);
					//print((maxmagaz - Magaz));
					Magaz = Magaz +(maxmagaz - Magaz);				
					vseg.text = vsep.ToString();
				}
				else{
					Magaz = maxmagaz - (vsep);
						vsep = 0;
				}

				/*Magaz = vsep + Magaz;
				vsep -= Magaz;
				Magaz = Magaz;
				maxmagaz = vsep;*/
			}
		}
		ost.text = Magaz.ToString();
		vseg.text = vsep.ToString();
	}
}
