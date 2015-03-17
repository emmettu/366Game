using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public bool grounded = false;
	
	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Ground") {
			grounded = true;
			Debug.Log("Grounded!");
		}
	}
	void OnTriggerExit2D(Collider2D collision) {
		if (collision.gameObject.tag == "Ground") {
			grounded = false;
			Debug.Log("Ungrounded");
		}
	}
}
