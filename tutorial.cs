using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {

	public GameObject tut1;
	public GameObject tut2;
	public GameObject tut3;
	public GameObject tut4;
	public GameObject tut5;
	public GameObject tut6;
	public GameObject tut7;
	public GameObject tut8;
	public GameObject tut9;
	public GameObject tut10;
	public int mode;
	public static int mod;

	// Use this for initialization
	void Start () {
		tut1.SetActive(false);
		tut2.SetActive(false);
		tut3.SetActive(false);
		tut4.SetActive(false);
		tut5.SetActive(false);
		tut6.SetActive(false);
		tut7.SetActive(false);
		tut8.SetActive(false);
		tut9.SetActive(false);
		tut10.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		mod = mode;
		mode = mod;
		switch (mode) {
		case 1:
			tut1.SetActive(true);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 2:
			tut1.SetActive(false);
			tut2.SetActive(true);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 3:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(true);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 4:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(true);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 5:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(true);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 6:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(true);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 7:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(true);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 8:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(true);
			tut9.SetActive(false);
			tut10.SetActive(false);
			break;
		case 9:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(true);
			tut10.SetActive(false);
			break;
		case 10:
			tut1.SetActive(false);
			tut2.SetActive(false);
			tut3.SetActive(false);
			tut4.SetActive(false);
			tut5.SetActive(false);
			tut6.SetActive(false);
			tut7.SetActive(false);
			tut8.SetActive(false);
			tut9.SetActive(false);
			tut10.SetActive(true);
			break;
			
		}
	}
}
