using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scroling : MonoBehaviour {
	

	public void Scrool(float value){
		float visotapaneli = this.GetComponent<RectTransform>().sizeDelta.y;
		print (value.ToString() + " /// " + ((visotapaneli * value) + 228f).ToString());
		this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, (visotapaneli * value) + 228f, this.gameObject.transform.position.z);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
