using UnityEngine;
using System.Collections;

public class Heroweapon2 : MonoBehaviour {
	public int Damage = 5;
	private bool canDamage = true;
	public static bool enabled = false;

	void Update(){
		if(enabled = true)
		{
			gameObject.SetActive(true);
		}
		else if(enabled = false)
		{
			gameObject.SetActive(false);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Bandit1") {
			EnemyHealth.healthNumBandit1 -= Damage;
			canDamage = false;
			col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 75);
		}
		if (col.gameObject.tag == "Bandit2"){
			EnemyHealth.healthNumBandit2 -= Damage;
			canDamage = false;
			col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 75);
		}
		if (col.gameObject.tag == "Bandit3"){
			EnemyHealth.healthNumBandit3 -= Damage;
			canDamage = false;
			col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 75);
		}
	}	
			
}