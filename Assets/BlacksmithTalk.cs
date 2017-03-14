using UnityEngine;
using System.Collections;

public class BlacksmithTalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(SmithyScript.isPlaying == true)
		{
			GetComponent<AudioSource>().Play();
		}
		else if(SmithyScript.isPlaying == false)
		{
			GetComponent<AudioSource>().Stop ();
		}
	}
}
