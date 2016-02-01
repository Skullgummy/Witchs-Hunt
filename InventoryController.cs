using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class InventoryControllerScript : MonoBehaviour
{

	/*GAMEOBJECT VARIABLES*/
	public GameObject[] inventoryBtn;
	public GameObject playerScript;

	void Update ()
	{
		PlayerControllerScript playerInventory = playerScript.GetComponent<PlayerControllerScript> ();

		for (int i = 0; i < inventoryBtn.Length; i++) {
			inventoryBtn [i].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [i].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [i];
			if (playerInventory.inventoryAmount [i] <= 0) {
				inventoryBtn [i].GetComponent<Button> ().interactable = false;
			}
		}
	}

	public void InventoryActivate ()
	{
		PlayerControllerScript playerInventory = playerScript.GetComponent<PlayerControllerScript> ();

		//turn on tuning stone slot
		if (playerInventory.inventoryAmount [0] > 0) {
			inventoryBtn [0].GetComponent<Button> ().interactable = true;
			inventoryBtn [0].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [0].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [0];
		}
		//turn on golden herbs slot
		if (playerInventory.inventoryAmount [1] > 0) {
			inventoryBtn [1].GetComponent<Button> ().interactable = true;
			inventoryBtn [1].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [1].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [1];
		}
		//turn on emerald mushrooms
		if (playerInventory.inventoryAmount [2] > 0) {
			inventoryBtn [2].GetComponent<Button> ().interactable = true;
			inventoryBtn [2].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [2].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [2];
		}
		//turn on air flies slot
		if (playerInventory.inventoryAmount [3] > 0) {
			inventoryBtn [3].GetComponent<Button> ().interactable = true;
			inventoryBtn [3].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [3].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [3];
		}
		//turn on towering flowers slot
		if (playerInventory.inventoryAmount [4] > 0) {
			inventoryBtn [4].GetComponent<Button> ().interactable = true;
			inventoryBtn [4].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [4].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [4];
		}
		//turn on geyser steam slot
		if (playerInventory.inventoryAmount [5] > 0) {
			inventoryBtn [5].GetComponent<Button> ().interactable = true;
			inventoryBtn [5].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [5].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [5];
		}	
		//turn on liquid frogs slot
		if (playerInventory.inventoryAmount [6] > 0) {
			inventoryBtn [6].GetComponent<Button> ().interactable = true;
			inventoryBtn [6].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [6].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [6];
		}
		//turn on crystal water
		if (playerInventory.inventoryAmount [7] > 0) {
			inventoryBtn [7].GetComponent<Button> ().interactable = true;
			inventoryBtn [7].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [7].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [7];
		}
		//turn on thick mud
		if (playerInventory.inventoryAmount [8] > 0) {
			inventoryBtn [8].GetComponent<Button> ().interactable = true;
			inventoryBtn [8].GetComponentInChildren<Text> ().text = "";
			inventoryBtn [8].GetComponentInChildren<Text> ().text += playerInventory.inventoryAmount [8];
		}
	}
}
