using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnGUI() {

		int mw = Screen.width / 2;
		int mh = Screen.height / 2;

		GUI.Box(new Rect(0, 0, Screen.height, Screen.width), "GAME OVER\nScore: " + PlayerPrefs.GetInt("Score"));
	}
}
