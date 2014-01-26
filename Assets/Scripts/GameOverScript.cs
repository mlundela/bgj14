using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnGUI() {
		GUI.Box(new Rect(0, 0, Screen.height, Screen.width), "GAME OVER\nScore: " + PlayerPrefs.GetInt("Score"));
	}
}
