using UnityEngine;
using System.Collections;

public class insaneSoundVolume : MonoBehaviour {

	public GameObject player;
	HealthScript ht;
	public AudioSource inSane;
	
	
	// Use this for initialization
	void Start () {
		
		ht = player.GetComponent<HealthScript> ();
		//player.transform.position.x
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	//	Debug.Log (ht.health);
		inSane.volume = 1- (float) ht.health / ht.MAX_HEALTH;
	//	Debug.Log (sane.volume);
	}
}
