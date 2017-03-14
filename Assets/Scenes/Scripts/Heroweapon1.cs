using UnityEngine;
using System.Collections;

public class Heroweapon1 : MonoBehaviour {
	public int Damage = 10;
	void GetValue(){
		print (EnemyHealth.healthNumBandit1);
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "Enemy") {
			EnemyHealth.healthNumBandit1 -= Damage;
		}
	}		
}