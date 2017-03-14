using UnityEngine;
using System.Collections;

public class SmithyScript : MonoBehaviour {

	public static InputController controller;
	public GameObject Hero;
	public GameObject Text;
	public GameObject Main_Character_sword;
	public static bool Is_first_time = true;
	public static bool isPlaying = false;

	void Awake(){
		controller = Hero.GetComponent<InputController>();
		}
	void finishCutscene(){
		Text.SetActive(false);
		controller.enabled = true;
		Is_first_time = false;
		Main_Character_sword.SetActive (true);
		Heroweapon.enabled = true; 
		isPlaying = false;
		}
	void OnTriggerEnter2D(Collider2D other){
				if (Is_first_time == true) {
						if (other.name == "Hero") {
				isPlaying = true;
								controller.enabled = false;
				other.GetComponent<Animation>().Stop ();
								Text.SetActive (true);
				InputController.moving = false;
				// need to wait for something; seconds, key press, something
				Invoke("finishCutscene", 15);
												  }
											}
											}
										}
		


