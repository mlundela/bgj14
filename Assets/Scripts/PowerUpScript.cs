using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	HealthScript hs;
	public AudioSource sound;

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("OnTriggerEnter2D");
		if (other.tag == "Player") {
			hs = other.GetComponent<HealthScript>();
			hs.IncreaseHealth(250);
			sound.Play();
			Destroy(this.gameObject);
		}
	}
}
