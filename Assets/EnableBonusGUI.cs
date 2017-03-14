using UnityEngine;
using System.Collections;

public class EnableBonusGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (MoneyGet.isGot == true) {
			gameObject.GetComponent<GUITexture>().enabled = true;
				}
	}
}
