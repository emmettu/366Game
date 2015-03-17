using UnityEngine;
using System.Collections;

public class ScoreZone : MonoBehaviour {

	// Use this for initialization
	public bool player = true;
	public GameObject Score;

	void Start () {
		Score = GameObject.Find("Score");
	}

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Ball" ) {
			Debug.Log(Score.guiText.text);
			int text = int.Parse(Score.guiText.text);

			if(player) {
				Score.guiText.text = (++text).ToString();
				Debug.Log("Scored!");
			}
			else {
				Score.guiText.text = (--text).ToString();
				Debug.Log("Unscored!");

			}
		}
	}
}
