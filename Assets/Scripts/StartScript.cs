using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	void OnMouseClick() {
		Debug.Log("Mouse click...");
		Application.LoadLevel (1);
	}
}
