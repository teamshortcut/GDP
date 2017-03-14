using UnityEngine;
using System.Collections;

public class HitColliderTester : MonoBehaviour {
	public PolygonCollider2D collider;
	public Animation swordSwing;
	public static bool playDieAnim1 = false;
	public static bool playDieAnim2 = false;
	public static bool playDieAnim3 = false;
	public static bool playDieAnim4 = false;
	public static bool playDieAnim5 = false;
	public static bool swordEnabled = false;
	public int Damage = 5;
	private bool canDamage = true;
	void Start (){
		collider = GetComponent<PolygonCollider2D>();
		swordSwing = GetComponent<Animation>();
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Space) == true)
		{
			collider.enabled = true;
			GetComponent<Animation>().Play();
		}
		if(swordSwing.isPlaying == false)
		{
			collider.enabled = false;
		}
		if(collider.enabled == true)
		{
			swordEnabled = true;
		}
		if(collider.enabled == false)
		{
			swordEnabled = false;
		}
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Bandit1")
		{
			GetComponent<AudioSource>().Play ();
		}
		if (other.gameObject.tag == "Bandit2")
		{
			GetComponent<AudioSource>().Play();
		}
		if (other.gameObject.tag == "Bandit3")
		{
			GetComponent<AudioSource>().Play();
		}
		if (other.gameObject.tag == "Bandit4")
		{
			GetComponent<AudioSource>().Play();
		}
		if (other.gameObject.tag == "Bandit5")
		{
			GetComponent<AudioSource>().Play();
		}
	}

}
 