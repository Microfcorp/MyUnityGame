using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class craft : MonoBehaviour {

	public int cub;
	public Inventar inv;
	public GameObject Player;
	public GameObject rec1;
	public GameObject rec2;
	public GameObject rec3;
	public GameObject rec4;
	public GameObject rec5;
	private bool man;
	public Scrollbar scrollbar;
	public GameObject[] settings = new GameObject[1];

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		cub = inv.kolichestvo;
		scrollbar.size = (float)(1f / (float)cub);
		if (cub >= 1) {
			rec1.SetActive (true);
			rec4.SetActive (false);
			rec2.SetActive (false);
			rec3.SetActive (false);
			rec5.SetActive (false);
		} if (cub >= 2) {
			rec1.SetActive (true);
			rec4.SetActive (true);
			rec2.SetActive (true);
			rec3.SetActive (false);
			rec5.SetActive (false);
		}
		if (cub >= 3) {
			rec1.SetActive (true);
			rec4.SetActive (true);
			rec2.SetActive (true);
			rec3.SetActive (true);
			rec5.SetActive (false);
		}if (cub >= 20) {
			rec1.SetActive (true);
			rec4.SetActive (true);
			rec2.SetActive (true);
			rec3.SetActive (true);
			rec5.SetActive (true);
		}if (cub <= 0) {
			rec1.SetActive (false);
			rec4.SetActive (false);
			rec2.SetActive (false);
			rec3.SetActive (false);
			rec5.SetActive (false);
		}
		if (man) {
			rec3.SetActive (false);                  
		}
	} 
	public void craft1(){
		cub -= 1;
		inv.kolichestvo -= 1;
		if (inv.vesInv == 0) {}
		else{ inv.vesInv -= 1;}
		//Inventar.kolichestvo -= 1;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("fonar"));
		gameObject.transform.position = Player.transform.position + Player.transform.forward + Player.transform.up;
	}
	public void craft2(){
		cub -= 2;
		inv.kolichestvo -= 2;
		if (inv.vesInv == 0) {}
		else{ inv.vesInv -= 2;}
		//Inventar.kolichestvo -= 1;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Ganmodel"));
		gameObject.transform.position = Player.transform.position + Player.transform.forward + Player.transform.up;
	}
	public void craft3(){
		cub -= 3;
		inv.kolichestvo -= 3;
		if (inv.vesInv == 0) {}
		else{ inv.vesInv -= 3;}
		//Inventar.kolichestvo -= 1;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Remkomp"));
		gameObject.transform.position = Player.transform.position + Player.transform.forward + Player.transform.up;
		man = true;
	}
	public void craft4(){
		cub -= 1;
		inv.kolichestvo -= 1;
		if (inv.vesInv == 0) {}
		else{ inv.vesInv -= 1;}
		//Inventar.kolichestvo -= 1;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Patroni"));
		gameObject.transform.position = Player.transform.position + Player.transform.forward + Player.transform.up;
	}
	public void craft5(){
		cub -= 20;
		inv.kolichestvo -= 20;
		if (inv.vesInv == 0) {}
		else{ inv.vesInv -= 20;}
		//Inventar.kolichestvo -= 1;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("House"));
		gameObject.transform.position = new Vector3(Player.transform.position.x + 50, 0, Player.transform.position.z) + Player.transform.forward + new Vector3(0,0,0);
		gameObject.GetComponentInChildren<inhouse> ().Spawn = settings [0];
		gameObject.GetComponentInChildren<inhouse> ().Player = settings [1];
		GameObject.Find ("House").GetComponentInChildren<outhouse> ().Spawn = gameObject.GetComponentInChildren<inhouse> ().Out;
	}
}
