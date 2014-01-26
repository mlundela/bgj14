using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
	
	private float speedX;
	private float speedY;
	private float positionX;
	private float positionY;
	private bool playerPassed;
	private float playerX;
	private float playerY;
	private float time;



	private HealthScript hs;
	private PlayerPosition pp;

	public GameObject Player;
	public GameObject playerPosition;




	// Use this for initialization
	void Start () {
		hs = Player.GetComponent<HealthScript>();
		pp = hs.GetComponent<PlayerPosition> ();
		speedX = -4.0f;
	}
	
	// Update is called once per frame
	void Update () {
		playerX = pp.getPositionX ();
		playerY = pp.getPositionY ();
		positionX = transform.position.x;
		positionY = transform.position.y;
		if (hs.isSick()) {

			//TODO: Fly mot spiller, inntil spiller er passert.
			// Aktiver fiendeutseende.
			//hostileAppearance();

			if (playerX > positionX)
				flyLeft ();
			else
				flyAgainstPlayer();
				


		} else {
			//TODO: Flyr tvers over skjermen
			// Hvis fugl er for langt nede ma den fly opp igjen.
			// 
			//friendlyAppearance();

			if (positionY<5) 
				flyUp();
				
			else if (positionY>10)
				flyDown();
			else
				flyLeft();
				
		}
		rigidbody2D.velocity = new Vector2(speedX,speedY);

		

	
	}
	private void flyAgainstPlayer() {
		if (playerY < positionY)
						speedY = -4.0f;
				else if (playerY > positionY)
						speedY = 4.0f;
				else
						speedY = 0.0f;
	}

	private void flyUp() {
		speedY = 1.0f;

	}

	private void flyLeft() {
		time += Time.deltaTime;
		speedY = Mathf.Sin(time)/2;

	}


	private void flyDown() {
		speedY = -1.0f;
	}
}
