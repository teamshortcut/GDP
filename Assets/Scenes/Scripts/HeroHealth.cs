using UnityEngine;
using System.Collections;

public class HeroHealth : MonoBehaviour {
	public static int healthValue = 3;

	void PrintHealth(){
				print (healthValue);
		}		
	// Update is called once per frame
	void Update () {

		if (healthValue <= 0) {
			//Time.timeScale = 0;
			gameObject.GetComponent<GameOver>().enabled = true;
			this.gameObject.transform.Find("MainCharacter_Sword").gameObject.SetActive(false);
		}
	}
}