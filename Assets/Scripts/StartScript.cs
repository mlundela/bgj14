using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	
	void OnGUI() {
		if (GUI.Button (new Rect (35, 140, 60, 30), "Start")) {
			Application.LoadLevel(1);		
		}
	}
}
