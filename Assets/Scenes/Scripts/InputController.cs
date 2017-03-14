using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{
	public static bool facingRight = true;			// For determining which way the player is currently facing.
	public bool jump = true;				// Condition for whether the player should jump.
	public static bool moving = false;


	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 5f;				// The fastest the player can travel in the x axis.
	public float jumpForce = 1000f;			// Amount of force added when the player jumps.

	
	public Transform groundCheck;			// A position marking where to check if the player is grounded.
	private bool grounded = false;									// Whether or not the player is grounded.
	private Animator anim;			// Reference to the player's animator component.
	private bool ladderCheck = false;
	public Animation playerWalk;

	private float xvelocity;

	void Awake()
	{
		// Setting up references.
		groundCheck = transform.Find("groundCheck");
		anim = GetComponent<Animator>();
	}


	void Update()
	{
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));  

		// If the jump button is pressed and the player is grounded then the player should jump.
		if(Input.GetButtonDown("Jump") && grounded)
			jump = true;

		if (Input.GetAxis("Horizontal") > 0) {
			GetComponent<Animation>().Play ();
				}

		if (Input.GetAxis("Horizontal") < 0) {
			GetComponent<Animation>().Play ();
		}

		if (Input.GetAxis("Horizontal") == 0) {
			GetComponent<Animation>().Stop();
				}
		print (moving);
		if (moving == false) //If player is not moving, stop all horizontal forces on the player.
		{
			GetComponent<Rigidbody2D>().angularVelocity = 0f;
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow) == true ||Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow))
		{
			moving = false;
		}
		else
		{
			moving = true;
		}
		print(moving);
	}



	void FixedUpdate ()
	{
		// Cache the horizontal input.
		float h = Input.GetAxis("Horizontal");

		// The Speed animator parameter is set to the absolute value of the horizontal input.
		//anim.SetFloat("Speed", Mathf.Abs(h));

		// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
		if (h * GetComponent<Rigidbody2D>().velocity.x < maxSpeed) {
						// ... add a force to the player.
						GetComponent<Rigidbody2D>().AddForce (Vector2.right * h * moveForce);
						moving = true;
				}
		else {
			moving = false;
		}

		// If the player's horizontal velocity is greater than the maxSpeed...
		if (Mathf.Abs (GetComponent<Rigidbody2D>().velocity.x) > maxSpeed) {
						// ... set the player's velocity to the maxSpeed in the x axis.
						GetComponent<Rigidbody2D>().velocity = new Vector2 (Mathf.Sign (GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
						moving = true;
				} 
		else {
			moving = false;
				}

		// If the input is moving the player right and the player is facing left...
		if(h > 0 && !facingRight)
			// ... flip the player.
			Flip();
		// Otherwise if the input is moving the player left and the player is facing right...
		else if(h < 0 && facingRight)
			// ... flip the player.
			Flip();

		// If the player should jump...
		if(jump)
		{

			// Add a vertical force to the player.
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
			moving = true;

			// Make sure the player can't jump again until the jump conditions from Update are satisfied.
			jump = false;
		}
		//if (Input.GetButtonDown("Jump") && LadderCheck.canClimb == true)
		//{
			//gameObject.rigidbody2D.gravityScale = 0;
			//rigidbody2D.AddForce(new Vector2(0f, 250));
			//print("Ladder");
		//}
		if(LadderCheck.canClimb == false)
		{
			GetComponent<Rigidbody2D>().gravityScale = 1;
		}

	}
	
	
	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}


}
