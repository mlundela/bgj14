using UnityEngine;
using System.Collections;

public class groundLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(rigidbody2D.transform.position.)
		rigidbody2D.velocity = new Vector2 (-3.0f ,  0.0f);

	}
}
