using UnityEngine;
using System.Collections;

public class PlayBanditDieAnim5 : MonoBehaviour {
	public Animation dieAnim;
	private bool stopAnim = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (HitColliderTester.playDieAnim5 == true && stopAnim == false)
		{
			dieAnim.Play ();
			stopAnim = true;
		}
	}
}
