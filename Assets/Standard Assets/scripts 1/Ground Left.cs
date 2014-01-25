using UnityEngine;
using System.Collections;

public class Left : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//transform.localPosition.x = transform.localPosition.x-3;
		rigidbody2D.velocity = new Vector2 (-3.0f ,  0.0f);

	}
}
