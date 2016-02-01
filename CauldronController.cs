using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CauldronScript : MonoBehaviour
{
	/*GENERAL VARIABLES*/
	public bool isMixing;
	public bool gameWin;
	private Vector3 forestFamiliarPosition = new Vector3 (-6f, 0f, 1.5f);
	private Vector3 meadowFamiliarPosition = new Vector3 (-3f, 2.5f, 1.5f);
	private Vector3 lakeFamiliarPosition = new Vector3 (4.5f, 0f, 1.5f);

	/*GAMEOBJECT VARIABLES*/
	public GameObject cauldronEffect;
	public GameObject gameController;
	public GameObject[] inventoryButton;
	public GameObject[] familiarList;

	/*MIXING HUD*/
	public Slider forestBar;
	public Slider meadowBar;
	public Slider lakeBar;

	/*MIXING VARIABLES*/
	private int[] mixtureAmount;
	private bool[] familiarCount;

	// Use this for initialization
	void Start ()
	{
		gameWin = false;

		//number 3 for 3 familiars
		familiarCount = new bool[3];
		for (int i = 0; i < familiarCount.Length; i++) {
			familiarCount [i] = false;
		}

		//number 3 because 3 zones/ familiars
		mixtureAmount = new int[3];
		for (int i = 0; i < mixtureAmount.Length; i++) {
			mixtureAmount [i] = 0;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		CauldronMix ();
		SpawnFamiliar ();
		forestBar.value = mixtureAmount [0];
		meadowBar.value = mixtureAmount [1];
		lakeBar.value = mixtureAmount [2];
	}

	void SpawnFamiliar ()
	{
		GameControllerScript timeCount = gameController.GetComponent<GameControllerScript> ();

		if (mixtureAmount [0] >= 25 && !familiarCount [0]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			Instantiate (cauldronEffect, forestFamiliarPosition, Quaternion.Euler (-90, 0, 0));
			Instantiate (familiarList [0], forestFamiliarPosition, Quaternion.identity);

			familiarCount [0] = true;
			timeCount.timeLeft = timeCount.timeLeft + 30;
		} else if (mixtureAmount [1] >= 25 && !familiarCount [1]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (1, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			Instantiate (cauldronEffect, meadowFamiliarPosition, Quaternion.Euler (-90, 0, 0));
			Instantiate (familiarList [1], meadowFamiliarPosition, Quaternion.identity);

			familiarCount [1] = true;
			timeCount.timeLeft = timeCount.timeLeft + 30;
		} else if (mixtureAmount [2] >= 25 && !familiarCount [2]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 0, 1, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			Instantiate (cauldronEffect, lakeFamiliarPosition, Quaternion.Euler (-90, 0, 0));
			Instantiate (familiarList [2], lakeFamiliarPosition, Quaternion.identity);

			familiarCount [2] = true;
			timeCount.timeLeft = timeCount.timeLeft + 30;
		}

		if(familiarCount[0] && familiarCount[1] && familiarCount[2])
		{
			gameWin = true;
		}
			
	}

	void CauldronMix ()
	{
		//Forest Mixtures
		ButtonControllerScript stoneState = inventoryButton [0].GetComponent<ButtonControllerScript> ();
		ButtonControllerScript herbState = inventoryButton [1].GetComponent<ButtonControllerScript> ();
		ButtonControllerScript shroomState = inventoryButton [2].GetComponent<ButtonControllerScript> ();
		//Meadow Mixtures
		ButtonControllerScript fliesState = inventoryButton [3].GetComponent<ButtonControllerScript> ();
		ButtonControllerScript flowerState = inventoryButton [4].GetComponent<ButtonControllerScript> ();
		ButtonControllerScript steamState = inventoryButton [5].GetComponent<ButtonControllerScript> ();
		//Lake Mixtures
		ButtonControllerScript frogState = inventoryButton [6].GetComponent<ButtonControllerScript> ();
		ButtonControllerScript waterState = inventoryButton [7].GetComponent<ButtonControllerScript> ();
		ButtonControllerScript mudState = inventoryButton [8].GetComponent<ButtonControllerScript> ();

		//Forest Mixture Values
		if (stoneState.itemDrop [0]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [0] = mixtureAmount [0] + 3; //increases familiar level by 3
			stoneState.itemDrop [0] = false;
		} else if (herbState.itemDrop [1]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [0] = mixtureAmount [0] + 3; //increases familiar level by 3
			herbState.itemDrop [1] = false;
		} else if (shroomState.itemDrop [2]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [0] = mixtureAmount [0] + 3; //increases familiar level by 3
			shroomState.itemDrop [2] = false;
		}

		//Meadow Mixture Values
		if (fliesState.itemDrop [3]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (1, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [1] = mixtureAmount [1] + 3; //increases familiar level by 3
			fliesState.itemDrop [3] = false;
		} else if (flowerState.itemDrop [4]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (1, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [1] = mixtureAmount [1] + 3; //increases familiar level by 3
			flowerState.itemDrop [4] = false;
		} else if (steamState.itemDrop [5]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (1, 1, 0, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [1] = mixtureAmount [1] + 3; //increases familiar level by 3
			steamState.itemDrop [5] = false;
		}

		//Lake Mixture Values
		if (frogState.itemDrop [6]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 0, 1, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [2] = mixtureAmount [2] + 3; //increases familiar level by 3
			frogState.itemDrop [6] = false;
		} else if (waterState.itemDrop [7]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 0, 1, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [2] = mixtureAmount [2] + 3; //increases familiar level by 3
			waterState.itemDrop [7] = false;
		} else if (mudState.itemDrop [8]) {
			cauldronEffect.GetComponent<ParticleSystem> ().startColor = new Color (0, 0, 1, 1f);
			Instantiate (cauldronEffect, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler (-90, 0, 0));
			mixtureAmount [2] = mixtureAmount [2] + 3; //increases familiar level by 3
			mudState.itemDrop [8] = false;
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag == "Player") {
			isMixing = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") {
			isMixing = false;
		}
	}
}
