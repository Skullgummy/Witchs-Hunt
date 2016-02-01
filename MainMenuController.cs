using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuControllerScript : MonoBehaviour {

	/*GAMEOBJECT VARIABLES*/
	public Canvas MainMenu;
	public Canvas ControlsMenu;

	// Use this for initialization
	void Awake () {
		MainMenu.enabled = true;
		ControlsMenu.enabled = false;
	}
	
}
