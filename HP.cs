using UnityEngine; 
using System.Collections; 
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class HP : MonoBehaviour { 
	
	public int maxHealth = 100; 
	public int curHealth = 100; 
	public float healthBarLength; 
	public kill ki;
	public GameObject Minimap; 
	public GameObject kill;
	public GameObject Player;
	
	void Start () { 
		healthBarLength = Screen.width/2; 
		if(maxHealth<1) maxHealth=1; 
	//	curHealth = maxHealth; 
	} 
	
	void Update () { 
		ShowCurrentHealth(curHealth); 
		if(curHealth == 0)
		{
			Minimap.SetActive(false);
			kill.SetActive(true);
			Player.SetActive(false);
			ki.kil = 1;
			Debug.Log("kill");
		}
	} 
	
	void OnGUI () { 
		
		GUI.Box(new Rect(10,40,healthBarLength,20),curHealth+"/"+maxHealth); 
	} 
	public void ShowCurrentHealth(int sch){ 
		curHealth = sch; 
		if(curHealth < 0) curHealth = 0; 
		if(curHealth > maxHealth) curHealth = maxHealth; 
		healthBarLength = (Screen.width/2) * (curHealth / (float)maxHealth);
	
	} 
}