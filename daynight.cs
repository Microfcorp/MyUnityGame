using UnityEngine;
using System.Collections;

public class daynight : MonoBehaviour {

		
		public float speed; // cкорость задаём прямо в Unity
	    public static int day;
	   // public GameObject solnze;
	    private static int dayn;
		void Start () {
		}
		void Update () {
			transform.Rotate(Vector3.right * (Time.deltaTime*speed)); //вращение по оси x
			transform.Rotate(Vector3.up * (Time.deltaTime*speed));  //вращение по оси y
		//if (transform.Rotate(Vector3.up) == 316.5134){
		//	Debug.Log ("night");
		//40.62298 вечер
		//316.5134 ночь
		//241 день

	//}
		}
	}

