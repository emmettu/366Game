using UnityEngine;
using System.Collections;

public class Kick : MonoBehaviour {

	public bool kickable = false;

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Ball" ) {
			kickable = true;
			//Debug.Log("Grounded!");
		}
	}
	void OnTriggerExit2D(Collider2D collision) {
		if (collision.gameObject.tag == "Ball") {
			kickable = false;
			//Debug.Log("Ungrounded");
		}
	}

}
