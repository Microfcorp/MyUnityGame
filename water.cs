using UnityEngine;
using System.Collections;

public class water : MonoBehaviour {

	public HP hp;
	//public GameObject wate;
	//public GameObject Player;
	public string player;
	public int vozduh = 100;
	public GameObject wat;
	public bool go;
	private int ostvoz = 100;
	private float t;
	private float tim = 0.5f;

	// Use this for initialization
	void Start () {
	
		ostvoz = vozduh;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (go) {
			wat.SetActive(true);
			if (Time.time - t > tim) { // алгоритм задержки между отниманием жизней 
				ostvoz -= 1; // сам процесс нанесения урона
				t = Time.time; // завершение задержки 
			}
			if (ostvoz < 1) {
				hp.curHealth -= 10;
				ostvoz = vozduh / 3;
			}
		} else {
			wat.SetActive(false);
		}

	}

	void OnTriggerEnter (Collider other) {  
		if (other.name == player) {  
			ostvoz = vozduh;
			this.go = true;
		}
	}
	void OnTriggerExit (Collider other) {  
		if (other.name == player) {  

			this.go = false;
		}
	}

	void OnGUI()
	{
		if(go)
		{
			GUI.Box (new Rect (Screen.width / 2 - 25, Screen.height / 2 - 45, 50, 70), ostvoz.ToString()); // центр
		}
	}
}
