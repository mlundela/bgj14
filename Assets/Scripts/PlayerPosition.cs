using UnityEngine;
using System.Collections;

public class PlayerPosition : MonoBehaviour {

	private float positionX;
	private float positionY;

	public GameObject player;

	public float getPositionX () {
		return player.transform.position.x;
	}
	public float getPositionY () {
		return player.transform.position.y;
	}

	

}
