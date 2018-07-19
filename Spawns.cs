using UnityEngine;
using System.Collections;

public class Spawns : MonoBehaviour {

	public GameObject Objectq;
	private float t;
	[Range(0,500)]public float time = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - t > time) { // алгоритм задержки между отниманием жизней 

			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Objectq); 
			gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;

			t = Time.time; // завершение задержки 
		}
	}
}
