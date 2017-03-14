using UnityEngine;
using System.Collections;

public class LakeReset : MonoBehaviour {
	public int Positionx;
	public int Positiony;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.tag == "HeroParent")
		{
			col.gameObject.transform.position = new Vector2(Positionx, Positiony);
			GetComponent<AudioSource>().Play();
		}
	}
}
