using UnityEngine;
using System.Collections;

public class Droping : MonoBehaviour {

	public GameObject objecte;
	public string drop;
	public AI ai;
	private float y;

	// Use this for initialization
	void Start () {
		ai = GetComponent<AI> ();
	}
	
	// Update is called once per frame
	void Update () {
	
			if(ai.curHealth == 0){
				//y = ai.transform.position.y + 6f;
				//objecte.transform.position = new Vector3 (ai.transform.position.x, y, ai.transform.position.z);
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(drop)); 
				gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
				this.enabled = false;
			}
		}
}
