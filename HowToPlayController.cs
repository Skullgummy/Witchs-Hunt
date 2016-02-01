using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HowToPlayControllerScript : MonoBehaviour
{
	/*GAMEOBJECT VARIABLES*/
	public Canvas howtoMenu;
	public Text titleTxt;
	public Text objectiveTxt;
	public Image controlsImg;

	// Use this for initialization
	void Start ()
	{
		ObjectivesMenu();
	}

	public void ObjectivesMenu ()
	{
		titleTxt.text = "Objective";
		controlsImg.enabled = false;
		objectiveTxt.enabled = true;
	}

	public void ControlsMenu ()
	{
		titleTxt.text = "Controls";
		objectiveTxt.enabled = false;
		controlsImg.enabled = true;
	}

	public void RecipiesMenu ()
	{
		titleTxt.text = "Recipies";
		controlsImg.enabled = false;
		objectiveTxt.enabled = false;
	}

	public void CloseMenu()
	{
		howtoMenu.enabled = false;
	}
}
