using UnityEngine;  
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Demage : MonoBehaviour {
	public string Player;
	public HP hp; // Ссылка на скрипт HP.cs 
	public int uron; // Урон который будет наносить зомби 
	public float AttacTime; // Период между атаками 
	private float t; // второстипенная переменная необходимая для выполнения логики

	void OnTriggerEnter (Collider other) {  
		if (other.tag == Player) {  
			hp = other.GetComponent<HP>(); // назночение ссылки hp скрипта игрока которого коснулся тригер 
			if (Time.time - t > AttacTime){ // алгоритм задержки между отниманием жизней 
				hp.curHealth -= uron; // сам процесс нанесения урона 
				t = Time.time; // завершение задержки 
			} 
		}  
	}  
}