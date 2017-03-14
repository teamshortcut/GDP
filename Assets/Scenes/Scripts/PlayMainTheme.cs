using UnityEngine;
using System.Collections;

public class PlayMainTheme : MonoBehaviour {
	public AudioSource mainTheme;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (PlaySmithMusic.inSmithery == true && PlaySmithMusic.canBePlayedMain == false)
		{
		
		}
		if (PlaySmithMusic.inSmithery == false && PlaySmithMusic.canBePlayedMain == true)
		{
			mainTheme.Play();
			PlaySmithMusic.canBePlayedMain = false;
		}
		if (PlayEndLvMusic.levelEnded == true)
		{
			mainTheme.Stop ();
		}
	}
}
