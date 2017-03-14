using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public float MoveSpeed = 5;
	private bool facingRight = false;
	private bool movingRight = false;
	public static bool facingRightPublic;
	public static bool movingRightPublic;

	void Update(){
		facingRightPublic = facingRight;
		movingRightPublic = movingRight;
		}

	void OnTriggerStay2D (Collider2D other){
		if (other.name == "Hero") {
			if (other.transform.position.x < transform.position.x){
				GetComponent<Rigidbody2D>().AddForce( new Vector2(-MoveSpeed, 0));
				movingRight = false;
			}
			else if (other.transform.position.x > transform.position.x){
					GetComponent<Rigidbody2D>().AddForce( new Vector2(MoveSpeed, 0));
					movingRight = true;
				}
			else{
				}


			if (movingRight == true && facingRight == false)
			{
				Flip();
				print ("Flipped");
			}
			else if (movingRight == false && facingRight == true)
			{
				Flip();
				print ("Flipped");
			}
			else
			{

			}


			//if(transform.position.x <
		}
	}

	void Flip()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		movingRight = !movingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

		// Maybe use vector 3 where x and z are the same as before using variables set to the current values. Use transform.eulerDegrees. Declare r in variables bit.
}