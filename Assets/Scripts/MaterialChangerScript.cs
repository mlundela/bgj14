using UnityEngine;
using System.Collections;

public class MaterialChangerScript : MonoBehaviour {


	void FixedUpdate() {
		float newAlpha = (Mathf.Sin(Time.time / 2f) + 1f) / 2f;
		//float newAlpha = .5f;
		Debug.Log("New alpha: " + newAlpha);
		Color originalColour = renderer.material.color;
		renderer.material.color = new Color(originalColour.r, originalColour.g, originalColour.b, newAlpha);
	}
}
