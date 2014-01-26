using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {


	public float speed = 0;

	void Update () {
		//renderer.material = renderer.materials[1];
		renderer.material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
	}
}
