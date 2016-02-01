using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonControllerScript : MonoBehaviour
{
	/*GENERAL VARIABLES*/
	public bool[] itemDrop;

	/*GAMEOBJECT VARIABLES*/
	public GameObject playerScript;
	public GameObject inventoryScript;
	public GameObject cauldronScript;

	void Start ()
	{
		itemDrop = new bool[9];
		for(int i = 0; i < itemDrop.Length; i++)
		{
			itemDrop[i] = false;
		}
	}

	//Forest items
	public void DropStone ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [0]--;
		updateAmount.inventoryBtn [0].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [0].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [0];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[0] = true;
		}
	}

	public void DropHerbs ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [1]--;
		updateAmount.inventoryBtn [1].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [1].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [1];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[1] = true;
		}
	}

	public void DropMushrooms ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [2]--;
		updateAmount.inventoryBtn [2].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [2].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [2];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[2] = true;
		}
	}

	//Meadow items
	public void DropFlies ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [3]--;
		updateAmount.inventoryBtn [3].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [3].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [3];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[3] = true;
		}
	}

	public void DropFlowers ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [4]--;
		updateAmount.inventoryBtn [4].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [4].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [4];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[4] = true;
		}
	}

	public void DropSteam ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [5]--;
		updateAmount.inventoryBtn [5].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [5].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [5];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[5] = true;
		}
	}
		
	//Lake items
	public void DropFrog ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [6]--;
		updateAmount.inventoryBtn [6].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [6].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [6];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[6] = true;
		}
	}

	public void DropWater ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [7]--;
		updateAmount.inventoryBtn [7].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [7].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [7];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[7] = true;
		}
	}

	public void DropMud ()
	{
		PlayerControllerScript itemAmount = playerScript.GetComponent<PlayerControllerScript> ();
		InventoryControllerScript updateAmount = inventoryScript.GetComponent<InventoryControllerScript> ();

		itemAmount.inventoryAmount [8]--;
		updateAmount.inventoryBtn [8].GetComponentInChildren<Text> ().text = "";
		updateAmount.inventoryBtn [8].GetComponentInChildren<Text> ().text += itemAmount.inventoryAmount [8];

		//Ready to drop item into cauldron
		CauldronScript cauldronInteract = cauldronScript.GetComponent<CauldronScript>();
		if(cauldronInteract.isMixing)
		{
			itemDrop[8] = true;
		}
	}
}
