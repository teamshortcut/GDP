using UnityEngine;
using System.Collections;

public class PlaySmithMusic : MonoBehaviour {
	public AudioSource blacksmithMusic;
	public static bool inSmithery = false;
	public static bool test = false;
	public static bool canBePlayedMain = true;
	private bool isPlayed = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.tag == "Hero")
		{
			blacksmithMusic.Play();
			inSmithery = true;
			print("In Trigger");
		}
	}
	void OnTriggerExit2D (Collider2D col)
	{
		if(col.gameObject.tag == "Hero")
		{
			blacksmithMusic.Stop();
			inSmithery = false;
		}
	}
}
