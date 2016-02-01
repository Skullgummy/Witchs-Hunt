using UnityEngine;
using System.Collections;

public class BGScrollerScript : MonoBehaviour {

	/*GENERAL VARIABLES*/
	public int speed;
	
	// Update is called once per frame
	void Update () {
		ScrollMovemnet();
	}

	void ScrollMovemnet() {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}
}
