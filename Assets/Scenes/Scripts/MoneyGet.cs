using UnityEngine;
using System.Collections;

public class MoneyGet : MonoBehaviour {
	public AudioSource moneyGetSound;
	private bool canBePlayed = true;
	public static bool isGot = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D()
	{
		if (canBePlayed) {
						moneyGetSound.Play ();
						canBePlayed = false;
			isGot = true;
						print ("Played");
						Invoke ("destroy", 0.5f);
				}
	}

	void destroy()
	{
		Destroy (gameObject);
	}
}
