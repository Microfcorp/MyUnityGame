using UnityEngine;
using System.Collections;

public class mistrig : MonoBehaviour {

	public int sluq;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			switch (sluq) {
			case 1:
				if(missing.modex < 1){
				missing.modex = 1;
				}
				break;
			case 2:
				if(missing.modex < 2){
				missing.modex = 2;
				}
				break;
			case 3:
				if(missing.modex < 3){
				missing.modex = 3;
				}
				break;
			case 4:
					if(missing.modex < 4){
				missing.modex = 4;
					}
				break;
			case 5:
						if(missing.modex < 5){
				missing.modex = 5;
						}
				break;
			case 6:
							if(missing.modex < 6){
				missing.modex = 6;
				}
				break;
							
			}
		}
		
	}
}
