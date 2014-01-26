using UnityEngine;
using System.Collections;

public class volumeDelayLoop : MonoBehaviour {

	public AudioSource sound;
	
	
	// Use this for initialization
	void Start () {
	
		sound.PlayDelayed (104.0f);
		sound.loop = true;

		//player.transform.position.x
	}

}
