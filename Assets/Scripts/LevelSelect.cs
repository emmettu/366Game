using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			int i = Application.loadedLevel;
			Application.LoadLevel(++i);
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();		
		}
	}
}
