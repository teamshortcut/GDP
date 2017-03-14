using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.P) == true)
		{
			Time.timeScale = 0.0f;
			//Time.deltaTime = 0.0f;
		}
		if(Input.GetKey (KeyCode.R) == true)
		{
			Time.timeScale = 1.0f;
		}
	}
}
