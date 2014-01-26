using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	/* Variabler ikke brukt enda.
	private float speed;
	private float speedX;
	private float speedY;
	//*/
	private float playerDistance;
	private float positionY;

	private HealthScript hs;

	public GameObject healthScript;




	// Use this for initialization
	void Start () {
		hs = healthScript.GetComponent<HealthScript>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hs.isSick()) {
			//TODO: Fly mot spiller, inntil spiller er passert.
			// Aktiver fiendeutseende.
			hostileAppearance();
			if (true)
				flyAgainstPlayer();
			else
				flyAgainstPlayer();
				


		} else {
			//TODO: Flyr tvers over skjermen
			// Hvis fugl er for langt nede ma den fly opp igjen.
			// 
			friendlyAppearance();
			if (positionY>5) 
				flyLeft();
			else
				flyUp();
		}
		

	
	}
	private void flyAgainstPlayer() {
		
	}

	private void flyUp() {

	}

	private void flyLeft() {

	}

	private void hostileAppearance() {

	}

	private void friendlyAppearance() {

	}
}
