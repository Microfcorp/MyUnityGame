using UnityEngine;
using System.Collections;

public class regeneration : MonoBehaviour {

	public HP hp;
	public int helt = 2;
	public float RegTime = 3; // Период между атаками
	public bool go;
	private float t; // второстипенная переменная необходимая для выполнения логик

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (go) {
			if (Time.time - t > RegTime){ // алгоритм задержки между отниманием жизней 
				hp.curHealth += helt; // сам процесс нанесения урона 
				t = Time.time; // завершение задержки 
			}
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			hp = other.GetComponent<HP>(); // назночение ссылки hp скрипта игрока которого коснулся тригер 
			go = true;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			go = false;
		}
	}
}
