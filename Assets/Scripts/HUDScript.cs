using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float score = 0;
	public GameObject player;
	HealthScript ht;

	void Start(){
		ht = player.GetComponent<HealthScript> ();
	}

	void Update () {

		if (ht.isSick ()) {
			score += Time.deltaTime*2;
				} else {
						score += Time.deltaTime;
				}
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
