using UnityEngine;
using System.Collections;

public class saneSoundVolume : MonoBehaviour {

	public GameObject player;
	HealthScript ht;
	public AudioSource sane;


	// Use this for initialization
	void Start () {

		ht = player.GetComponent<HealthScript> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	//	Debug.Log (ht.health);
			sane.volume = (float) ht.health / ht.MAX_HEALTH;
	//	Debug.Log (sane.volume);
	}
}
