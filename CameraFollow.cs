using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {

	/*GENERAL VARIABLES*/
	public bool isFollowing;

	/*GAMEOBJECT VARIABLES*/
	public Transform playerPosition;

	void Start() {
		isFollowing = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isFollowing) {
			transform.position = new Vector3 (playerPosition.position.x, 1, -5);
		}
	}
}
