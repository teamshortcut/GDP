using UnityEngine;
using System.Collections;

public class SwingDummy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(InputController.facingRight == true)
		{
			GetComponent<Animation>().Play ();
			print ("Hit");
		}
		else if (InputController.facingRight == false)
		{
			GetComponent<Animation>().Play ();
			print ("Hit Left");
		}
	}
}
