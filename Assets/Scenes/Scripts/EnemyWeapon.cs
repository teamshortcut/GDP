using UnityEngine;
using System.Collections;

public class EnemyWeapon : MonoBehaviour {
	public int EnemyDamage = 1;
	void GetValue(){
		print(HeroHealth.healthValue);
	}
		
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "HeroParent") {
			HeroHealth.healthValue -= EnemyDamage;
			print ("Hit");
			other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 75);
			print ("Force");
		}
	}		
}