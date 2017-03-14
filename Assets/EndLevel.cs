using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {

	public Texture backgroundTexture;

	public GUIStyle style;

	public float guiPlacementX1;
	public float guiPlacementY1;

	public float guiPlacementX2;
	public float guiPlacementY2;

	public float guiPlacementX3;
	public float guiPlacementY3;

	public AudioClip click;
	public AudioClip cancel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		GUI.Label(new Rect(185, 185, 10000, 2000), "Thank you for playing Project MAR! \nCheck out our website for more games\n and projects from us!", style);
		if (GUI.Button (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "www.shortcutgames.com")) {
			GetComponent<AudioSource>().PlayOneShot(click);
			Application.OpenURL("http://www.shortcutgames.com");
		}
		if (GUI.Button (new Rect (Screen.width * guiPlacementX3, Screen.height * guiPlacementY3, Screen.width * .5f, Screen.height * .1f), "Quit Game")) {
			GetComponent<AudioSource>().PlayOneShot(cancel);	
			Application.Quit();
		}
	}
}
