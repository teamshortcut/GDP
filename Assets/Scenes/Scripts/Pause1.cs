using UnityEngine;
using System.Collections;

public class Pause1 : MonoBehaviour {

	public Texture aTexture;

	private int pauseInt = 1;

	private float pauseTop = 0;
	private float pauseLeft = 0;
	private float pauseWidth = 0;
	private float pauseHeight = 0;

	private float guiTop = 0;
	private float guiLeft = 0;
	private float guiWidth = 0;
	private float guiHeight = 0;


	// Use this for initialization
	void Start () {
		EnemyHealth.healthNumBandit1 = 15;
		EnemyHealth.healthNumBandit2 = 15;
		EnemyHealth.healthNumBandit3 = 15;
		HeroHealth.healthValue = 3;
		Heroweapon.enabled = false;
		Heroweapon2.enabled = false;
		HitColliderTester.playDieAnim1 = false;
		HitColliderTester.playDieAnim2 = false;
		HitColliderTester.playDieAnim3 = false;
		InputController.facingRight = true;
		PlayEndLvMusic.levelEnded = false;
		PlaySmithMusic.inSmithery = false;
		PlaySmithMusic.test = false;
		PlaySmithMusic.canBePlayedMain = true;
		SmithyScript.Is_first_time = true;
		SmithyScript.controller.enabled = true;
		Heroweapon2.enabled = false;
		HitColliderTester.swordEnabled = false;
		EnemyMovement.facingRightPublic = false;
		EnemyMovement.movingRightPublic = false;
		InputController.moving = false;
		MoneyGet.isGot = false;
	}
	
	// Pause and Unpause
	void Update () {
		if(Input.GetKeyDown(KeyCode.P) == true || Input.GetKeyDown(KeyCode.Escape) == true)
		{
			if(pauseInt == 1)
			{
				Time.timeScale = 0.0f;
				//Time.deltaTime = 0.0f;
				pauseInt = 2;
				pauseTop = 70;
				pauseLeft = Screen.width / 2.75f;
				pauseWidth = 355;
				pauseHeight = 415;

				guiTop = 160;
				guiLeft = Screen.width / 2.75f + 12;
				guiWidth = 332;
				guiHeight = 92;
				AudioListener.volume = 0.5f;
			}
			else
			{
				Time.timeScale = 1.0f;
				pauseInt = 1;
				pauseTop = 0;
				pauseLeft = 0;
				pauseWidth = 0;
				pauseHeight = 0;

				guiTop = 0;
				guiLeft = 0;
				guiWidth = 0;
				guiHeight = 0;
				AudioListener.volume = 1.0f;
			}
		}
	}
	
	void OnGUI () {

		if (pauseInt == 2) {
			GUI.DrawTexture (new Rect (pauseLeft, pauseTop, pauseWidth, pauseHeight), aTexture, ScaleMode.ScaleToFit, true, 1.0F);

			if (GUI.Button (new Rect (guiLeft, guiTop, guiWidth, guiHeight), "Resume Game")) {
				Time.timeScale = 1.0f;
				pauseInt = 1;
				pauseTop = 0;
				pauseLeft = 0;
				pauseWidth = 0;
				pauseHeight = 0;

				guiTop = 0;
				guiLeft = 0;
				guiWidth = 0;
				guiHeight = 0;
			}

			if (GUI.Button (new Rect (guiLeft, guiTop + 96, guiWidth, guiHeight), "Return To Start Menu")) {
				Application.LoadLevel("MainMenu");
			}

			if (GUI.Button (new Rect (guiLeft, guiTop + 192, guiWidth, guiHeight), "Quit Game")) {
				Application.Quit();
			}
		}
	}
}
