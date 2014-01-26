using UnityEngine;
using System.Collections;

public class MaterialChangerScript : MonoBehaviour {

	public GameObject player;
	HealthScript hs;

	void Start() 
	{
		hs = player.GetComponent<HealthScript> ();
	}


	void FixedUpdate() {
		float health = hs.GetHealtAsFloat();
		float newAlpha = health * health * health * health;
		Debug.Log("New alpha: " + newAlpha);
		Color originalColour = renderer.material.color;
		renderer.material.color = new Color(originalColour.r, originalColour.g, originalColour.b, newAlpha);
	}
}
