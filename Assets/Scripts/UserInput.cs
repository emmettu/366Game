using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	// Use this for initialization
	private Movement movement;
	void Start () {
		movement = (Movement) GetComponent<Movement> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		move ();
	}
	void move() {
		if (Input.GetKey (KeyCode.UpArrow)) {
			movement.jump();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			movement.moveLeft();
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			movement.moveRight();
		}
		if (Input.GetKey (KeyCode.Space)) {
			movement.kick();
		}
	}
}
