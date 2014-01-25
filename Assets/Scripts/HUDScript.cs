using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float score = 0;

	void Update () {
		score += Time.deltaTime;
	}

	void OnDisable() {
		PlayerPrefs.SetInt("Score", GetScore());
	}

	void OnGUI() {
		GUI.Label (new Rect (10, 100, 100, 30), "Score: " + GetScore ());
	}

	private int GetScore() {
		return (int)(score * 100);
	}
}
