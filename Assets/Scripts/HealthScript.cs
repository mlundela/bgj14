using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int MAX_HEALTH = 1600;
	public int health;

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

	public bool isSick ()
	{
		return health < MAX_HEALTH / 2.0f;
	}

}
