using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	// Change this for each enemy for their health
	public static int healthNumBandit1 = 15;
	public static int healthNumBandit2 = 15;
	public static int healthNumBandit3 = 15;
	public static int healthNumBandit4 = 15;
	public static int healthNumBandit5 = 15;

	// Update is called once per frame
	void Update () {
		if (healthNumBandit1 <= 0) {
			print ("Dead");			
			HitColliderTester.playDieAnim1 = true;
				}
		if (healthNumBandit2 <= 0) {
			print ("Dead");			
			HitColliderTester.playDieAnim2 = true;
		}
		if (healthNumBandit3 <= 0) {
			print ("Dead");			
			HitColliderTester.playDieAnim3 = true;
		}
		if (healthNumBandit4 <= 0) {
			print ("Dead");			
			HitColliderTester.playDieAnim4 = true;
		}
		if (healthNumBandit5 <= 0) {
			print ("Dead");			
			HitColliderTester.playDieAnim5 = true;
		}
	
	}
}
