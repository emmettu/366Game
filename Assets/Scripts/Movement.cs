using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private int jumpHeight = 720;
	private int speed = 50;
	private int kickHeight = 400;
	private int kickLength = 1000;
	private GameObject ball;

	void Start() {
		ball = GameObject.FindWithTag ("Ball");
	}

	public void jump() {
		if (GetComponentInChildren<Jump>().grounded) {
				rigidbody2D.AddForce (Vector2.up * jumpHeight);
		}
	}
	public void moveRight() {
		rigidbody2D.AddForce (Vector2.right * speed);
	}
	public void moveLeft() {
		rigidbody2D.AddForce (Vector2.right * - speed);
	}
	public void kick() {
		if (GetComponentInChildren<Kick> ().kickable) {
			ball.rigidbody2D.AddForce(Vector2.up * kickHeight);
			ball.rigidbody2D.AddForce(Vector2.right * kickLength);
		}
	}
}
