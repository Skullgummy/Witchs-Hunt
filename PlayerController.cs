using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour
{

	/*GENERAL VARIABLES*/
	private int speedBase = 5;
	private bool interactReady;
	private bool isInteracting;
	private bool isBook;

	/*GAMEOBJECT VARIABLES*/
	public GameObject playerImage;
	public GameObject cameraObject;
	public GameObject inventoryScript;
	public GameObject item;

	/*HUD VARIABLES*/
	public Text prompt;
	public Canvas howtoCanvas;

	/*ANIMATION VARIABLES*/
	Animator animator;

	/*INVENTORY*/
	public int[] inventoryAmount;
	public bool[] activeItem;

	// Use this for initialization
	void Start ()
	{
		//initialize anim to player sprite
		animator = playerImage.GetComponent<Animator> ();

		//Initialize variables at start
		interactReady = false;
		prompt.enabled = false;

		//startup array length
		inventoryAmount = new int[9];
		activeItem = new bool[9];

		//set all interaction to false
		for (int i = 0; i < activeItem.Length; i++) {
			activeItem [i] = false;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Player can always move kukuku
		Movement ();
	}

	void Movement ()
	{
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * speedBase * Time.deltaTime);
			playerImage.transform.localScale = new Vector3 (2f, 2f, 1f);
			animator.Play ("PlayerWalkAnimation");
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * speedBase * Time.deltaTime);
			playerImage.transform.localScale = new Vector3 (-2f, 2f, 1f);
			animator.Play ("PlayerWalkAnimation");
		} else {
			animator.Play ("PlayerIdleAnimation");
		}

		//Interaction
		if (Input.GetMouseButton (0) && (interactReady)) {
			isInteracting = true;
			Interaction ();
		}
	}

	void Interaction ()
	{
		InventoryControllerScript inventoryDisplay = inventoryScript.GetComponent<InventoryControllerScript> ();

		if (isInteracting) {
			if (activeItem [0]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [0]++;
				inventoryDisplay.InventoryActivate (); //update inventory hud
				activeItem [0] = false;
			}
			if (activeItem [1]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [1]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [1] = false;
			}
			if (activeItem [2]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [2]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [2] = false;
			}
			if (activeItem [3]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [3]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [3] = false;
			}
			if (activeItem [4]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [4]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [4] = false;
			}
			if (activeItem [5]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [5]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [5] = false;
			}
			if (activeItem [6]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [6]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [6] = false;
			}
			if (activeItem [7]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [7]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [7] = false;
			}
			if (activeItem [8]) {
				Destroy (item);
				prompt.enabled = false;
				inventoryAmount [8]++;
				inventoryDisplay.InventoryActivate ();
				activeItem [8] = false;
			}
		
			if (isBook) {
				howtoCanvas.enabled = true;
			}
		}
	}

	void OnTriggerEnter (Collider other)
	{
		//Forest Items Interact
		if (other.tag == "Stone") {
			activeItem [0] = true; // yes this is a tuning stone
			item = other.gameObject; // assign object to item [to delete later]
			interactReady = true; //ready to click
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true; // show interact prompt
		}
		//now to do this for 8 other items yayyy, there needs to be an easier way...
		if (other.tag == "Herbs") {
			activeItem [1] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}
		if (other.tag == "Mushrooms") {
			activeItem [2] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}
		//Meadow Items Interact
		if (other.tag == "Flies") {
			activeItem [3] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}
		if (other.tag == "Flowers") {
			activeItem [4] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}
		if (other.tag == "Steam") {
			activeItem [5] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}
		//Lake Items Interact
		if (other.tag == "Frogs") {
			activeItem [6] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}
		if (other.tag == "Water") {
			activeItem [7] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}
		if (other.tag == "Mud") {
			activeItem [8] = true;
			item = other.gameObject;
			interactReady = true;
			prompt.text = "Pickup"; // type interact text
			prompt.enabled = true;
		}

		//interact with cauldron
		if (other.tag == "Cauldron") {
			prompt.text = "Mix";
			prompt.enabled = true;
		}

		//interact with book
		if (other.tag == "Book") {
			prompt.text = "How to Play";
			prompt.enabled = true;
			interactReady = true; //ready to click
			isBook = true;
		}

		//Camera Follow Trigger
		CameraFollowScript cameraFollow = cameraObject.GetComponent<CameraFollowScript> ();
		if (other.tag == "Follow") {
			cameraFollow.isFollowing = true;
		} else if (other.tag == "Stop") {
			cameraFollow.isFollowing = false;
		}

	}

	void OnTriggerExit (Collider other)
	{
		prompt.enabled = false;
		for (int i = 0; i < activeItem.Length; i++) {
			activeItem [i] = false;
		}
	}
}
