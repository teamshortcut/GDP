using UnityEngine;
using System.Collections;

public class GameOverSceneScript : MonoBehaviour {
	
	public Texture backgroundTexture;
	
	public GUIStyle Random1;
	
	public float guiPlacementY1;
	public float guiPlacementY2;
	
	public float guiPlacementX1;
	public float guiPlacementX2;

	private bool enabled = false;

	public GameObject Bonus;
	public GameObject Bandits;

	public GameObject Bandit1Group;
	public GameObject Bandit1;
	public GameObject Bandit1ArmLeft;
	public GameObject Bandit1ArmRight;
	public GameObject Bandit1Head;
	public GameObject Bandit1Body;
	public GameObject Bandit1LegLeft;
	public GameObject Bandit1LegRight;
	public GameObject Bandit1Mace;

	public GameObject Bandit2Group;
	public GameObject Bandit2;
	public GameObject Bandit2ArmLeft;
	public GameObject Bandit2ArmRight;
	public GameObject Bandit2Head;
	public GameObject Bandit2Body;
	public GameObject Bandit2LegLeft;
	public GameObject Bandit2LegRight;
	public GameObject Bandit2Mace;
	public GameObject Bandit2Sack;

	public GameObject Bandit3Group;
	public GameObject Bandit3;
	public GameObject Bandit3ArmLeft;
	public GameObject Bandit3ArmRight;
	public GameObject Bandit3Head;
	public GameObject Bandit3Body;
	public GameObject Bandit3LegLeft;
	public GameObject Bandit3LegRight;
	public GameObject Bandit3Mace;

	public float Positionx;
	public float Positiony;

	public float PositionxBandits;
	public float PositionyBandits;

	public float Positionx1Group;
	public float Positiony1Group;
	public float Positionx1;
	public float Positiony1;

	public float Positionx2Group;
	public float Positiony2Group;
	public float Positionx2;
	public float Positiony2;

	public float Positionx3Group;
	public float Positiony3Group;
	public float Positionx3;
	public float Positiony3;

	// Use this for initialization
	void Update () {
		if(enabled)
		{
			Time.timeScale = 1;
		}
	}
	
	// Update is called once per frame
	void OnGUI () {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
			if (GUI.Button (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Restart")) {
				print ("Clicked Play Game");
				//Application.LoadLevel("GDP Level");
			Invoke ("Restart", 0);
				//audio.PlayOneShot(startGame);
			}
			//Displays Quit Game button, plays sound when clicked, as well as quit the game.		
			if (GUI.Button (new Rect (Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Quit Game")) {
				print ("Clicked Quit Game");
				Application.Quit();
				//audio.PlayOneShot (cancel);
			}
	}

	void Restart()
	{
		//gameObject.transform.position = new Vector2(Positionx, Positiony);
		EnemyHealth.healthNumBandit1 = 15;
		EnemyHealth.healthNumBandit2 = 15;
		EnemyHealth.healthNumBandit3 = 15;
		HeroHealth.healthValue = 3;
		Heroweapon.enabled = false;
		HitColliderTester.playDieAnim1 = false;
		HitColliderTester.playDieAnim2 = false;
		HitColliderTester.playDieAnim3 = false;
		InputController.facingRight = true;
		PlayEndLvMusic.levelEnded = false;
		PlaySmithMusic.inSmithery = false;
		PlaySmithMusic.test = false;
		PlaySmithMusic.canBePlayedMain = true;
		SmithyScript.Is_first_time = true;
		Heroweapon2.enabled = false;
		HitColliderTester.swordEnabled = false;
		EnemyMovement.facingRightPublic = false;
		EnemyMovement.movingRightPublic = false;
		InputController.moving = false;
		MoneyGet.isGot = false;
		SmithyScript.isPlaying = false;
		Destroy(this);
		Application.LoadLevel("GDP Level");
		/*Bonus.SetActive(true);
		Bandit1ArmLeft.SetActive(true);
		Bandit1ArmRight.SetActive(true);
		Bandit1Head.SetActive(true);
		Bandit1Body.SetActive(true);
		Bandit1LegLeft.SetActive(true);
		Bandit1LegRight.SetActive(true);
		Bandit1Mace.SetActive(true);
		Bandit2ArmLeft.SetActive(true);
		Bandit2ArmRight.SetActive(true);
		Bandit2Head.SetActive(true);
		Bandit2Body.SetActive(true);
		Bandit2LegLeft.SetActive(true);
		Bandit2LegRight.SetActive(true);
		Bandit2Mace.SetActive(true);
		Bandit2Sack.SetActive(true);
		Bandit3ArmLeft.SetActive(true);
		Bandit3ArmRight.SetActive(true);
		Bandit3Head.SetActive(true);
		Bandit3Body.SetActive(true);
		Bandit3LegLeft.SetActive(true);
		Bandit3LegRight.SetActive(true);
		Bandit3Mace.SetActive(true);
		Bandits.transform.position = new Vector2(PositionxBandits, PositionyBandits);
		Bandit1Group.transform.position = new Vector2(Positionx1Group, Positiony1Group);
		Bandit1.transform.position = new Vector2(Positionx1, Positiony1);
		Bandit2Group.transform.position = new Vector2(Positionx2Group, Positiony2Group);
		Bandit2.transform.position = new Vector2(Positionx2, Positiony2);
		Bandit3Group.transform.position = new Vector2(Positionx3Group, Positiony3Group);
		Bandit3.transform.position = new Vector2(Positionx3, Positiony3);
		this.enabled = false;
		*/
	}
}
