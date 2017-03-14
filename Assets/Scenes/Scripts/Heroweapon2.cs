using UnityEngine;
using System.Collections;

public class Heroweapon : MonoBehaviour {
	public int Damage = 5;
	private bool canDamage = true;
	public static bool enabled = false;

	void Update(){
		if (HitColliderTester.swordEnabled == false) {
			canDamage = true;
		}
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
						if (canDamage == true) {
								EnemyHealth.healthNumBandit1 -= Damage;
								if (EnemyMovement.facingRightPublic == false) {
										col.gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * 100);
								} else {
										col.gameObject.GetComponent<Rigidbody2D>().AddForce (-Vector2.right * 100);
								}
						}
						canDamage = false;


				}
	
				if (col.gameObject.tag == "Bandit2") {
						if (canDamage == true) {
								EnemyHealth.healthNumBandit2 -= Damage;
								if (EnemyMovement.facingRightPublic == false) {
										col.gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * 100);
								} else {
										col.gameObject.GetComponent<Rigidbody2D>().AddForce (-Vector2.right * 100);
								}
			
						}
						canDamage = false;
				}
				if (col.gameObject.name == "Bandit3") {
						if (canDamage == true) {
								EnemyHealth.healthNumBandit3 -= Damage;
								if (EnemyMovement.facingRightPublic == false) {
										col.gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * 100);
								} else {
										col.gameObject.GetComponent<Rigidbody2D>().AddForce (-Vector2.right * 100);
								}
						}
						canDamage = false;
				}	

				if (col.gameObject.name == "Bandit4") {
					if (canDamage == true) {
						EnemyHealth.healthNumBandit4 -= Damage;
						if (EnemyMovement.facingRightPublic == false) {
							col.gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * 100);
						} else {
							col.gameObject.GetComponent<Rigidbody2D>().AddForce (-Vector2.right * 100);
						}
					}
					canDamage = false;
					
					
				}
				if (col.gameObject.name == "Bandit5") {
					if (canDamage == true) {
						EnemyHealth.healthNumBandit5 -= Damage;
						if (EnemyMovement.facingRightPublic == false) {
							col.gameObject.GetComponent<Rigidbody2D>().AddForce (Vector2.right * 100);
						} else {
							col.gameObject.GetComponent<Rigidbody2D>().AddForce (-Vector2.right * 100);
						}
					}
					canDamage = false;
					
					
				}
		}		
}
