using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	int MAX_HEALTH = 200;
	int health;

	void Start() {
		health = MAX_HEALTH;
	}

	void FixedUpdate() {

		health -= 1;
		
		if (health <= 0) {
			Application.LoadLevel (1);		
		} 
	}

	void OnGUI() {
		GUI.Box(new Rect(10, 10, 100, 90), "Healh: " + health);
	}

	public void IncreaseHealth(int amount) {
		health = Mathf.Min(health + amount, MAX_HEALTH);
	}

}
