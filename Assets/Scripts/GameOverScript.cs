using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void OnGUI() {
		
		GUI.Box(new Rect(10, 10, 100, 90), "GAME OVER");
	}
}
