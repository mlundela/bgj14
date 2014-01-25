using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	HealthScript hs;

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("OnTriggerEnter2D");
		if (other.tag == "Player") {
			hs = other.GetComponent<HealthScript>();
			hs.IncreaseHealth(500);
		}
	}
}
