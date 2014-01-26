using UnityEngine;
using System.Collections;



public class groundLeft : MonoBehaviour {

	public float leftSpeed = -2.0f;

	void Update () {
		rigidbody2D.velocity = new Vector2 (leftSpeed ,  0.0f);
	}
}
