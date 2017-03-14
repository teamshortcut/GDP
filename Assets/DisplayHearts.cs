using UnityEngine;
using System.Collections;

public class DisplayHearts : MonoBehaviour {
	public Texture heart;
	// Use this for initialization
	void Start () {

	}

	void OnGUI () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(HeroHealth.healthValue >= 3)
		{
			gameObject.SetActive(true);
		}
		else
		{
			gameObject.SetActive(false);
		}
	}
}
