using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Collections;


public class Inventar : MonoBehaviour
	
{
	public bool PlayerInventar; //переменная для переключения отображения инвентаря
	public List<Item> Items = new List<Item>();
	private Vector2 _inventoryScroll;
	public Transform cam4; //камера нашего персонажа из которой будет выходить луч
	private RaycastHit rch5; //сам луч
	public HP hp;
	public int kolichestvo;
	public int kolichestvo1;// количество
	public int kolichestvo2;// количество
	public int kolichestvo3;// количество
	public int kolichestvo4;// количество
	public bool showinwentory;
	public float vesInv; // вес всех предметов в инвентаре
	public float maxvesInv; // максимальны вес инвентар 
	public static int cubov;
	public GameObject gun;
	public GameObject bul;
	public GameObject fonar;

	
	private void Start()
	{
		//this.kolichestvo += settingmeny.kol;
		//this.vesInv += settingmeny.ves;

	}
	
	private void Update()
		
	{
		if (Input.GetKeyDown(KeyCode.Tab)) // при нажатии на tab наш инвентарь будет открываться и закрываться
		{
			this.PlayerInventar = !this.PlayerInventar;
		}
		
		Vector3 direction = this.cam4.TransformDirection(Vector3.forward); // луч, который будет выходить из камеры
		if (Physics.Raycast(this.cam4.position, direction, out this.rch5, 3f) && this.rch5.collider.GetComponent<Item>() != null && Input.GetKeyDown(KeyCode.E)) //и при столкновении с колайдером предмета, на котором есть компонент item и при нажатии на клавишу Е
		{
			Item component = this.rch5.collider.GetComponent<Item>();             
			if (component != null  & this.vesInv < 30f) // при условии что вес всех предметов не превышает максимальный вес инвентаря
			{
				this.Items.Add(component); // будет добавляться в инвентарь
				//settingmeny.kol += component.kolivo;
				//settingmeny.ves += component.ves;
				UnityEngine.Object.Destroy(this.rch5.collider.gameObject); // и удалятся со сцены
				this.vesInv += component.ves; // к общему весу инвентаря суммируется вес предмета
				if (component.type == "cub" & (float)component.kolivo > 0f) //если предмет имеет тип "cub" и его количество больше нуля
				{
					this.kolichestvo += component.kolivo; // то его количество в инвентаре суммируются
					cubov += 1;
				}
				if (component.type == "cub" & (float)this.kolichestvo > 1f) //если предмет имеет тип "cub" и его количество в инвентаре больше чем 1
				{
					this.Items.Remove(component); // то повторяющиеся предметы будут удалятся или суммироваться в один
				}
				if (component.type == "Instrument" & (float)component.kolivo > 0f) //если предмет имеет тип "cub" и его количество больше нуля
				{
					this.kolichestvo1 += component.kolivo; // то его количество в инвентаре суммируются
				}
				if (component.type == "Instrument" & (float)this.kolichestvo1 > 1f) //если предмет имеет тип "cub" и его количество в инвентаре больше чем 1
				{
					this.Items.Remove(component); // то повторяющиеся предметы будут удалятся или суммироваться в один
				}
				if (component.type == "oruzie" & (float)component.kolivo > 0f) //если предмет имеет тип "cub" и его количество больше нуля
				{
					this.kolichestvo2 += component.kolivo; // то его количество в инвентаре суммируются
				}
				if (component.type == "oruzie" & (float)this.kolichestvo2 > 1f) //если предмет имеет тип "cub" и его количество в инвентаре больше чем 1
				{
					this.Items.Remove(component); // то повторяющиеся предметы будут удалятся или суммироваться в один
				}
				if (component.type == "patroni" & (float)component.kolivo > 0f) //если предмет имеет тип "cub" и его количество больше нуля
				{
					this.kolichestvo4 += component.kolivo; // то его количество в инвентаре суммируются
				}
				if (component.type == "patroni" & (float)this.kolichestvo4 > 1f) //если предмет имеет тип "cub" и его количество в инвентаре больше чем 1
				{
					this.Items.Remove(component); // то повторяющиеся предметы будут удалятся или суммироваться в один
				}

			}
		}
	}
	
	
	public void OnGUI()
		
	{
		if (this.PlayerInventar) // если PlayerInventar = true, то выводим на экран графическую часть инвентаря.
		{
			GUI.Box(new Rect((float)(Screen.width / 3 - Screen.width / 3), (float)(Screen.height / 3 - Screen.height / 3), (float)Screen.width, (float)Screen.height), " ");
			if (this.showinwentory)
			{
				GUILayout.BeginArea(new Rect((float)(Screen.width / 2) + 250f, (float)(Screen.height / 2) - 250f, 400f, 500f), "Инвентарь", GUI.skin.box);
				GUILayout.Space(20f);
				if (GUILayout.Button("Закрыть", new GUILayoutOption[0]))
				{
					this.PlayerInventar = !this.PlayerInventar;
				}
				GUILayout.Label(this.vesInv + " кг/ 30кг", new GUILayoutOption[0]);
				this._inventoryScroll = GUILayout.BeginScrollView(this._inventoryScroll, new GUILayoutOption[]
				                                                  {
					GUILayout.ExpandHeight(true),
					GUILayout.ExpandWidth(true)
				});
				foreach (Item current in this.Items)
				{
					GUILayout.BeginVertical(GUI.skin.box, new GUILayoutOption[]
					                        {
						GUILayout.Width(300f)
					});
					GUILayout.Label(current.itemName, new GUILayoutOption[0]);
					GUILayout.Label(current.ves + " кг", new GUILayoutOption[0]);
					GUILayout.BeginHorizontal(new GUILayoutOption[0]);
					GUILayout.Label(current.inventoryTexture, new GUILayoutOption[0]);
					GUILayout.Label(current.opisanie, new GUILayoutOption[0]);
					GUILayout.BeginVertical(GUI.skin.box, new GUILayoutOption[]
					                        {
						GUILayout.Width(100f)
					});

					if (current.type == "cub")
					{
						GUILayout.Label(this.kolichestvo + "шт", new GUILayoutOption[0]);
						if (this.kolichestvo <= 0)
						{
							this.Items.Remove(current);
							
						}
						if (GUILayout.Button("Выложить", new GUILayoutOption[0]))
						{
							cubov -= 1;
							GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(current.prefab)); 
							gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
							
							this.vesInv -= current.ves;
							this.kolichestvo -= 1;
							//settingmeny.kol -= 1;
							//settingmeny.ves -= current.ves;
						}
						if (GUILayout.Button("Удалить", new GUILayoutOption[0]))
						{
							cubov -= 1;
							this.vesInv -= current.ves;
							this.kolichestvo -= 1;
							//settingmeny.kol -= 1;
							//settingmeny.ves -= current.ves;
						}
					}
					if (current.type == "Instrument")
					{
						GUILayout.Label(this.kolichestvo1 + "шт", new GUILayoutOption[0]);
						if (this.kolichestvo1 <= 0)
						{
							this.Items.Remove(current);
							
						}
						if (GUILayout.Button("Выкинуть", new GUILayoutOption[0]))
						{

							if(current.itemName == "Remkomp"){
								GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Remkomp")); 
								gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
								
								this.vesInv -= current.ves;
								this.kolichestvo1 -= 1;
							}
							else{
								GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(current.prefab)); 
								gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
								
								this.vesInv -= current.ves;
								this.kolichestvo1 -= 1;
							}
							//settingmeny.kol -= 1;
							//settingmeny.ves -= current.ves;
						}
						if (GUILayout.Button("Удалить", new GUILayoutOption[0]))
						{
							this.vesInv -= current.ves;
							this.kolichestvo1 -= 1;

							//settingmeny.kol -= 1;
							//settingmeny.ves -= current.ves;
						}
						if (GUILayout.Button("Разобрать", new GUILayoutOption[0]))
						{

							if(current.itemName == "Remkomp"){
							}
							else{
								GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(current.drop)); 
								gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
								
								this.vesInv -= current.ves;
								this.kolichestvo1 -= 1;
							}
							//settingmeny.kol -= 1;
							//settingmeny.ves -= current.ves;
						}
						if (GUILayout.Button("Использовать", new GUILayoutOption[0]))
						{
							if(current.itemName == "Remkomp"){
								hp.curHealth = 100;
								this.vesInv -= current.ves;
								this.kolichestvo1 -= 1;
								missing.modex = 2;
							}
							else{
								fonar.SetActive(!fonar.activeSelf);
							}

						}
					}
						if (current.type == "oruzie")
						{
							GUILayout.Label(this.kolichestvo2 + "шт", new GUILayoutOption[0]);
						    //GUILayout.Label("Горячая клавиша 1", new GUILayoutOption[0]);
							if (this.kolichestvo2 <= 0)
							{
								this.Items.Remove(current);
								
							}
							if (GUILayout.Button("Выкинуть", new GUILayoutOption[0]))
							{
								GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(current.prefab)); 
								gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
								
							gun.SetActive(false);
								this.vesInv -= current.ves;
								this.kolichestvo2 -= 1;
								//settingmeny.kol -= 1;
								//settingmeny.ves -= current.ves;
							}
						if (GUILayout.Button("Разобрать", new GUILayoutOption[0]))
						{
							GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(current.drop)); 
							gameObject.transform.position = base.transform.position + base.transform.forward + base.transform.up;
							GameObject gameObject1 = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>(current.drop)); 
							gameObject1.transform.position = base.transform.position + base.transform.forward + base.transform.up;
							gun.SetActive(false);
							this.vesInv -= current.ves;
							this.kolichestvo2 -= 1;
							//settingmeny.kol -= 1;
							//settingmeny.ves -= current.ves;
						}
							if (GUILayout.Button("Удалить", new GUILayoutOption[0]))
							{
							    gun.SetActive(false);
								this.vesInv -= current.ves;
								this.kolichestvo2 -= 1;
								//settingmeny.kol -= 1;
								//settingmeny.ves -= current.ves;
							}
						if (GUILayout.Button("Использовать", new GUILayoutOption[0]))
						{
							gun.SetActive(!gun.activeSelf);
							bul.SetActive(!bul.activeSelf);

						}
						if (GUILayout.Button("Зарядить", new GUILayoutOption[0]))
						{
							if(this.kolichestvo4 > 0){
								this.vesInv -= 1;
							this.kolichestvo4 -= 1;
							//gun.GetComponent<Pistolet>().maxmagaz += 10;
								gun.GetComponent<Pistolet>().vsep += 7;
							}
						}
						}
					if (current.type == "patroni")
					{
						GUILayout.Label(this.kolichestvo4 + "шт", new GUILayoutOption[0]);
						if (this.kolichestvo4 <= 0)
						{
							this.Items.Remove(current);
							
						}
						if (GUILayout.Button("Удалить", new GUILayoutOption[0]))
						{
							
							this.vesInv -= current.ves;
							this.kolichestvo4 -= 1;
							//settingmeny.kol -= 1;
							//settingmeny.ves -= current.ves;
						}
					}

			
					GUILayout.EndVertical();
					GUILayout.EndHorizontal();
					GUILayout.EndVertical();
				}
				GUILayout.EndScrollView();
				GUILayout.EndArea();
			}
		}
	}
}