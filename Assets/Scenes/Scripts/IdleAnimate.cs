using UnityEngine;
using System.Collections;

public class IdleAnimate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Animation>().Play("NPC Idle Rotate");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
