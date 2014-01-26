using UnityEngine;
using System.Collections;

public class groundLeft : MonoBehaviour {

	void Update () {
		rigidbody2D.velocity = new Vector2 (-2.0f ,  0.0f);
	}
}
