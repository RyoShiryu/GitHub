﻿using UnityEngine;
using System.Collections;

public class GUIMenu : MonoBehaviour {

void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Z-FIGHTER");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Fight !")) {
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(20,60,80,20), "Quit.")) {
			Application.Quit();
		}
	}
}