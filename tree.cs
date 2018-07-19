using UnityEngine;
using System.Collections;

public class tree : MonoBehaviour {

	public GameObject tre;
	public string drop;
	//public string prefabdrop;
	public int maxprn = 5;
	public int curprn = 5;
	public int udar = 1;
	public bool go;

	// Use this for initialization
	void Start () {
		curprn = maxprn;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (go) {
			if (Input.GetKeyDown (KeyCode.B)) {
				curprn -= udar;
			}
		}

		if (curprn == 0) {
			//tre.transform.position = new Vector3 (164, 5, 156);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(drop)); 
			gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
			Destroy (tre);

		}

	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			go = true;
		}
		if (other.tag == "Car") {
			curprn = 0;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			go = false;
		}
	}
	void OnGUI()
	{
		if (this.go) { // если PlayerInventar = true, то выводим на экран графическую часть инвентаря.
			GUI.Box (new Rect (0, Screen.height - 60, 1600, 100), "Что-бы рубить дерево нажмите B осталось" + " " + curprn + " " + "раз(а)");
		}
	}
}
