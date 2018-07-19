using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	private HP hp;
	//public Transform trn;
	private NavMeshAgent nma;
	public string Player = "Player";
	public int uron;
	private GameObject ai;
	//public Collider glaz;
	private float t;
	private float tim = 0.7f;
	//public GameObject mab;
	public int maxHealth = 3; 
	public int curHealth = 3; 
	private bool mob;
	public AIprovod pr;

	private Collider other;

	// Use this for initialization
	void Start () {
		ai = this.gameObject;
		if (settingmeny.slozn) {
			ai.SetActive (true);
		} else {
			Destroy (ai.gameObject);
		}

		if(maxHealth<-1) maxHealth=-1; 
		curHealth = maxHealth; 
		nma = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		//nma.SetDestination (trn.position);


		ShowCurrentHealth(curHealth); 
		if(curHealth == 0)
		{
			nma.enabled = false;
			//Destroy (mab.gameObject);
		}
		if(curHealth == -1)
		{
			Destroy (gameObject);
		}

		if (mob) {
			if (Input.GetKeyDown (KeyCode.B)) { // при нажатии на tab наш инвентарь будет открываться и закрываться
				curHealth -= 1;
			}
			
		}

		if (other != null) {
			//print(other.name);
			if (other.tag == Player) {
				mob = true;
				hp = other.GetComponent<HP>();
				if (Time.time - t > tim){ // алгоритм задержки между отниманием жизней 
					hp.curHealth -= uron; // сам процесс нанесения урона
					t = Time.time; // завершение задержки 
				}
			}	
			if (other.tag == "Provodnik") {
				pr = GetComponent<AIprovod>();
				pr.curprn -= 5;
			}

		}

	}

	void OnTriggerEnter (Collider other) {  
		this.other = other;

	}
	void OnTriggerExit (Collider other) {  
		this.other = null;
		if (other.tag == Player) {
			mob = false;
		}
		if (other.tag == "Provodnik") {
			pr = null;
		}
	}

	public void ShowCurrentHealth(int sch){ 
		curHealth = sch; 
		if(curHealth < -1) curHealth = -1; 
		if(curHealth > maxHealth) curHealth = maxHealth; 		
	}
}