using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public GameObject gam;
	void OnMouseOver()
	{
		if(Input.GetMouseButton(0))
		{
			Destroy (gam.gameObject);
		}
	}
}