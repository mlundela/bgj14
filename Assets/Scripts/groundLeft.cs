﻿using UnityEngine;
using System.Collections;

public class groundLeft : MonoBehaviour {

	void Update () {
		rigidbody2D.velocity = new Vector2 (-3.0f ,  0.0f);
	}
}
