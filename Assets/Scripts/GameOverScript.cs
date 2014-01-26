using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnGUI() {
		GUI.Box(new Rect(Screen.width/2 - 50, Screen.height/2 + 200, 100, 30), "Score: " + PlayerPrefs.GetInt("Score"));
	}
}
