using UnityEngine;
using System.Collections;

public class ListManagementScript : MonoBehaviour {

	/*GAMEOBJECT VARIABLES*/
	public GameObject gameController;

	void Awake ()
	{
		gameController = GameObject.Find("GameController");
		GameControllerScript itemCapacityList = gameController.GetComponent<GameControllerScript>();
		itemCapacityList.itemCap.Add(this.gameObject);
	}

	void OnDestroy()
	{
		GameControllerScript itemCapacityList = gameController.GetComponent<GameControllerScript>();
		itemCapacityList.itemCap.Remove(this.gameObject);
	}
}
