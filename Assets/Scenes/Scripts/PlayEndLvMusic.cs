using UnityEngine;
using System.Collections;

public class PlayEndLvMusic : MonoBehaviour {
	public AudioSource endlvTheme;
	public bool played = false;
	public static bool levelEnded = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "HeroParent" && levelEnded == false)
		{
			endlvTheme.Play ();
			levelEnded = true;
			SmithyScript.controller.enabled = false;
			PlaySmithMusic.canBePlayedMain = false;
			col.GetComponent<Animation>().Stop ();
			Invoke("DisplayScreen", 5);
		}
	}

	void DisplayScreen()
	{
		Application.LoadLevel("EndScreen");
	}
}