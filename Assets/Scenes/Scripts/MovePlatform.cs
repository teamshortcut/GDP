using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {
	public int distance;
	public int speed;
	private int negativeDistance;
	private bool correct = true;
	public Transform position;
	public int timesToRepeat = 15;
	// Use this for initialization
	void Start () {
		negativeDistance = Mathf.Abs(distance);
		PlatformMove();
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void PlatformMoveRight()
	{
		gameObject.transform.Translate(Vector2.right);
	}

	void PlatformMoveLeft()
	{
		gameObject.transform.Translate(-Vector2.right);
	}

	void PlatformMove()
	{
		for(int i = 0; i < timesToRepeat; i++)
			PlatformMoveRight();
	}
}
