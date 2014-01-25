using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {


	int health = 100;

	void Update () {

		health -= 1;
		
		if (health <= 0) {
			Application.LoadLevel (1);		
		} 
	}

	void OnGUI() {
		GUI.Box(new Rect(10, 10, 100, 90), "Healh: " + health);
	}

	public void IncreaseHealth(int amount) {
		health = Mathf.Min(health + amount, 1000);
	}

}
