using UnityEngine;
using System.Collections;

public class AIglas : MonoBehaviour {

	public string Player;
	private Transform trn;
	private NavMeshAgent nma;
	private bool vid;
	private float t;
	private float tim = 3.7f;
	/*public Transform go1;
	public Transform go2;
	public Transform go3;
	public Transform go4;
	public Transform go5;
	public Transform go6;*/
	private int go;
	private bool mob;
	private AI ai;

	private Collider other;
	// Use this for initialization
	void Start () {
		ai = GetComponentInParent<AI> ();
		nma = GetComponentInParent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		go = Random.Range(1,6);

		/*switch (go) {
//		case 1:
//		    nma.SetDestination (go1.position);
//	        break;
//		case 2:
//			nma.enabled = true;
//			nma.SetDestination (go2.position);
//			break;
//		case 3:
//			nma.SetDestination (go3.position);
//			break;
//		case 4:
//			nma.SetDestination (go4.position);
//			break;
//		case 5:
//			nma.SetDestination (go5.position);
//			break;
//		case 6:
//			nma.SetDestination (go6.position);
//			break;
//
		}*/

		if (vid) {

		}

		if (mob) {
			if (Input.GetKeyDown (KeyCode.B)) { // при нажатии на tab наш инвентарь будет открываться и закрываться
				ai.curHealth -= 1;
			}
			
		}

		if (other != null) {
			print(other.name);
			if (other.name == Player) {
				vid = true;
				nma.enabled = true;
				nma.SetDestination (other.gameObject.transform.position);
			}
			if (other.name == "Provodnik") {
				nma.enabled = true;
				nma.SetDestination (other.gameObject.transform.position);
			}
			if (other.tag == "Player") {
				mob = true;
			}
		}

	}

	void OnTriggerEnter (Collider other) {  
		if (other.name == Player) {
			this.other = other;
		}
	}
	void OnTriggerExit (Collider other) {  

		if (other.name == Player) {
			nma.enabled = false;
			vid = !vid;
				this.other = null;
		}
		if (other.name == "Provodnik") {
			nma.enabled = false;
			this.other = null;
		}
		if (other.tag == "Player") {
			mob = false;
			this.other = null;
		}
	}
	void OnGUI()
	{
		if (this.mob) { // если PlayerInventar = true, то выводим на экран графическую часть инвентаря.
			GUI.Box (new Rect (0, Screen.height - 60, 1600, 100), "Что-бы ударить cubebues нажмите В. Осталось" + " " + ai.curHealth + " " + "Ударов");
		}
	}
}
