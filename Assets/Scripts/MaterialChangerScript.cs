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
		//float newAlpha = (Mathf.Sin(Time.time / 2f) + 1f) / 2f;
		float health = hs.GetHealtAsFloat();
		float newAlpha = health * health;
		Debug.Log("New alpha: " + newAlpha);
		Color originalColour = renderer.material.color;
		renderer.material.color = new Color(originalColour.r, originalColour.g, originalColour.b, newAlpha);
	}
}
