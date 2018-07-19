using UnityEngine;
using System.Collections;

public class Spawnai : MonoBehaviour {

	public string AI;
	public int rand;
	private float t;
	private float tim = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//rand = Random.Range(15,30);
		if (Time.time - t > rand){ // алгоритм задержки между отниманием жизней 
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(AI));
			gameObject.transform.position = new Vector3(this.transform.position.x + Random.Range(0, 500) , this.transform.position.y, this.transform.position.z + Random.Range(0, 500));
			t = Time.time; // завершение задержки 
		}


		//Debug.Log (rand);

	}
}
