/// <summary>
/// Main Menu.
/// Attached to Main Camera
/// </summary>
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	public GUIStyle Random1;

	public float guiPlacementY1;
	public float guiPlacementY2;

	public float guiPlacementX1;
	public float guiPlacementX2;

	public AudioClip startGame;
	public AudioClip click;
	public AudioClip cancel;

	void OnGUI(){

// Displays our Background Texture
				GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

// Displays Play Game button, plays sound when clicked, as well as loads the level.
			if (GUI.Button (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Start Game")) {
					print ("Clicked Play Game");
					Application.LoadLevel("GDP Level");
			Time.timeScale = 1;
					//Destroy(this);
					GetComponent<AudioSource>().PlayOneShot(startGame);
				}
//Displays Quit Game button, plays sound when clicked, as well as quit the game.		
			if (GUI.Button (new Rect (Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Quit Game")) {
					print ("Clicked Quit Game");
					Application.Quit();
					GetComponent<AudioSource>().PlayOneShot (cancel);
				}
		}


}