using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	HealthScript hs;
	bool touched = false;
	public AudioSource sound;

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("OnTriggerEnter2D");
		if (other.tag == "Player" && touched == false) {
			hs = other.GetComponent<HealthScript>();
			hs.IncreaseHealth(200);
			touched = true;
			sound.Play();


		}
		//Destroy (this.gameObject);
	}
	void FixedUpdate () {
	if (!sound.isPlaying&&touched) {
			Destroy (this.gameObject);
				}

	}
}
