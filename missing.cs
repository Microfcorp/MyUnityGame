using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class missing : MonoBehaviour {

	public GameObject tog1;
	public GameObject tog2;
	public GameObject tog3;
	public GameObject tog4;
	public GameObject tog5;
	public GameObject tog6;
	public GameObject tex1;
	public GameObject tex2;
	public GameObject tex3;
	public GameObject tex4;
	public GameObject tex5;
	public GameObject tex6;
	public int mode;
	public static int modex;

	// Use this for initialization
	void Start () {
		tog1.SetActive(false);
		tog2.SetActive(false);
		tog3.SetActive(false);
		tog4.SetActive(false);
		tog5.SetActive(false);
		tog6.SetActive(false);
		tex1.SetActive(true);
		tex2.SetActive(false);
		tex3.SetActive(false);
		tex4.SetActive(false);
		tex5.SetActive(false);
		tex6.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		mode = modex;
		modex = mode;
		switch (mode) {
		case 1:
			tog1.SetActive (true);
			tog2.SetActive (false);
			tog3.SetActive (false);
			tog4.SetActive (false);
			tog5.SetActive (false);
			tog6.SetActive (false);
			tex1.SetActive (true);
			tex2.SetActive (true);
			tex3.SetActive (false);
			tex4.SetActive (false);
			tex5.SetActive (false);
			tex6.SetActive (false);
			tutorial.mod = 1; 
			break;
		case 2:
			tog1.SetActive (true);
			tog2.SetActive (true);
			tog3.SetActive (false);
			tog4.SetActive (false);
			tog5.SetActive (false);
			tog6.SetActive (false);
			tex1.SetActive (true);
			tex2.SetActive (true);
			tex3.SetActive (true);
			tex4.SetActive (false);
			tex5.SetActive (false);
			tex6.SetActive (false);
			tutorial.mod = 2; 
			break;
		case 3:
			tog1.SetActive (true);
			tog2.SetActive (true);
			tog3.SetActive (true);
			tog4.SetActive (false);
			tog5.SetActive (false);
			tog6.SetActive (false);
			tex1.SetActive (true);
			tex2.SetActive (true);
			tex3.SetActive (true);
			tex4.SetActive (true);
			tex5.SetActive (false);
			tex6.SetActive (false);
			tutorial.mod = 3; 
			break;
		case 4:
			tog1.SetActive (true);
			tog2.SetActive (true);
			tog3.SetActive (true);
			tog4.SetActive (true);
			tog5.SetActive (false);
			tog6.SetActive (false);
			tex1.SetActive (true);
			tex2.SetActive (true);
			tex3.SetActive (true);
			tex4.SetActive (true);
			tex5.SetActive (true);
			tex6.SetActive (false);
			tutorial.mod = 4; 
			break;
		case 5:
			tog1.SetActive (true);
			tog2.SetActive (true);
			tog3.SetActive (true);
			tog4.SetActive (true);
			tog5.SetActive (true);
			tog6.SetActive (false);
			tex1.SetActive (true);
			tex2.SetActive (true);
			tex3.SetActive (true);
			tex4.SetActive (true);
			tex5.SetActive (true);
			tex6.SetActive (true);
			tutorial.mod = 5; 
			break;
		case 6:
			tog1.SetActive (true);
			tog2.SetActive (true);
			tog3.SetActive (true);
			tog4.SetActive (true);
			tog5.SetActive (true);
			tog6.SetActive (true);
			tex1.SetActive (true);
			tex2.SetActive (true);
			tex3.SetActive (true);
			tex4.SetActive (true);
			tex5.SetActive (true);
			tex6.SetActive (true);
			tutorial.mod = 1; 
			break;
		}
	}
}
