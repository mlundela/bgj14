using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnGUI() {
		GUI.Box(new Rect(0, 0, 100, 25), "Score: " + PlayerPrefs.GetInt("Score"));

		if (GUI.Button (new Rect (Screen.width / 2 - 30, Screen.height / 2 - 10, 60, 30), "Retry?")) {
			Application.LoadLevel(1);		
		}
	}
}
