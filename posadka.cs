using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class posadka : MonoBehaviour {

	public string player;
	public GameObject Player;
	public GameObject Capsule;
	public GameObject Car;
	public GameObject carplay;
	public Camera camera;
	public Camera cemeracar;
	public GameObject inspawn;
	public GameObject outspawn;
	public GameObject fara;
	public GameObject Gan;
	public AI ai;
	//public script Car1;
	//public GameObject Car2;
	public bool posd;
	private int inout;
	private string ia = "UI";
	private static float xc;
	private static float yc;
	private static float zc;
	private static float xp;
	private static float yp;
	private static float zp;
	private int far = 0;

	void OnTriggerEnter(Collider other){ 
		if (other.name == player) {

			this.posd = true;
		}
		if (other.tag == "AI") {
			ai = other.GetComponent<AI>();
			ai.curHealth = -1;
		}
	}

	void OnTriggerExit(Collider other){ 
		if (other.name == player) {
			
			this.posd = false;
		}

	}
		

	void OnMouseOver()
	{
		if(Input.GetMouseButton(0))
		{

        }
	}

	void Start(){
		camera.enabled = true;//Включен (по стандарту).  
		cemeracar.enabled = false; //Отключен 
		//Car.GetComponent<CarUserControl>.enabled = false;
	}

	void Update(){

		if(inout == 1){
			xc = carplay.transform.position.x;
			yc = carplay.transform.position.y;
			zc = carplay.transform.position.z;
			Player.transform.position = new Vector3 (xc, yc, zc);
			//this.posd = !this.posd;

		}

		if (this.posd) { // если PlayerInventar = true, то выводим на экран графическую часть инвентаря.

			if (Input.GetKeyDown (KeyCode.F)) {
				if (far == 0) {
					fara.SetActive (true);
					far = 1;
				} else {
					fara.SetActive (false);
					far = 0;
				}
			}

			if(inout == 0){
			if (Input.GetKeyDown (KeyCode.H)) { // при нажатии на tab наш инвентарь будет открываться и закрываться
				Debug.Log ("go");
					this.GetComponent<CarUserControl>().enabled = true;
					//Player.SetActive(false);
				cemeracar.enabled = true;    
				camera.enabled = false; 
				xp = outspawn.transform.position.x;
				yp = outspawn.transform.position.y;
				zp = outspawn.transform.position.z;
				//Car1.(true);
				//		Car2.SetActive(true);
				//Player.transform.position = new Vector3 (0, 0, 0);
				//Player.transform.position = new Vector3 (xp, yp, zp);
				//Player.transform.position = new Vector3 (0, 0, 0);
				//this.posd = !this.posd;
				inout = 1;
				Capsule.SetActive (false);
				Gan.SetActive (false);
			} 
			}
			else{
			if (Input.GetKeyDown (KeyCode.H)) { // при нажатии на tab наш инвентарь будет открываться и закрываться
				Debug.Log ("out");
					this.GetComponent<CarUserControl>().enabled = false;
					//Player.SetActive(true);
				cemeracar.enabled = false;    
				camera.enabled = true; 
				xp = outspawn.transform.position.x;
				yp = outspawn.transform.position.y;
				zp = outspawn.transform.position.z;
				//Car1.SetActive(false);
				//	Car2.SetActive(false);
				camera.transform.position = new Vector3 (xp, yp, zp);
				Player.transform.position = new Vector3 (xp, yp, zp);
				//this.posd = !this.posd;
				inout = 0;
				//this.posd = !this.posd;
				Capsule.SetActive (true);
				//Gan.SetActive(true);
				fara.SetActive (false);
			} 
			}
		} 
	}

	void OnGUI()
	{
		if (this.posd) { // если PlayerInventar = true, то выводим на экран графическую часть инвентаря.
			if(inout == 0){
			GUI.Box (new Rect (0, Screen.height - 60, 1600, 100), "Что-бы сесть в машину нажмите H");
			}
			else{
				GUI.Box (new Rect (0, Screen.height - 60, 1600, 100), "Что-бы Выйти из машины нажмите H");
			}
		}
	}
}