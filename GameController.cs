using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class GameControllerScript : MonoBehaviour
{
	/*HUD VARIABLES*/
	public Text timerText;
	public Image fadeScreen;

	/*GENERAL VARIABLES*/
	private float fadeAmount;
	private int spawnX;
	private int spawnY;
	private int item;
	private int itemsLeft;
	public float timeLeft;

	/*COURUTINE VARIABLES*/
	public int itemCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	/*GAMEOBJECT VARIABLES*/
	public GameObject cauldronScript;
	public GameObject[] items;
	public List<GameObject> itemCap;

	void Start ()
	{
		itemCap = new List<GameObject> ();
		fadeScreen.enabled = false;
	}

	void Update ()
	{
		//if there are 21 or more items present stop spawning
		if (itemCap.Count >= 21) {
			
			StopAllCoroutines ();

		}
		else if(itemCap.Count <= 15)
		{
			StartCoroutine (ForestSpawn ());
			StartCoroutine (MeadowSpawn ());
			StartCoroutine (LakeSpawn ());
		}

		//start the timer
		Countdown();
	}

	void Countdown ()
	{
		timerText.text = "Time Left: " + (int)timeLeft;
		timeLeft -= Time.deltaTime;
		if(timeLeft <= 0)
		{
			timerText.color = new Color (1,0,0,1f);
			timeLeft = 0;
			GameOver();
		}

		CauldronScript familiarsSummoned = cauldronScript.GetComponent<CauldronScript>();
		//if all the familiars are present then the game wins
		if(familiarsSummoned.gameWin)
		{
			GameWin();
		}
	}
		
	//Timer for spawning Forest Items
	IEnumerator ForestSpawn ()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < itemCount; i++) {
				spawnX = Random.Range (26, 63);
				item = Random.Range (0, 3);
				Vector3 spawnPosition = new Vector3 (spawnX, -1f, 1.5f);
				Instantiate (items [item], spawnPosition, Quaternion.identity);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

	IEnumerator MeadowSpawn ()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < itemCount; i++) {
				spawnX = Random.Range (80, 116);
				item = Random.Range (3, 6);
				Vector3 spawnPosition = new Vector3 (spawnX, -1f, 1.5f);
				Instantiate (items [item], spawnPosition, Quaternion.identity);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

	IEnumerator LakeSpawn ()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < itemCount; i++) {
				spawnX = Random.Range (133, 168);
				item = Random.Range (6, 9);
				Vector3 spawnPosition = new Vector3 (spawnX, -1f, 1.5f);
				Instantiate (items [item], spawnPosition, Quaternion.identity);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

	void GameOver()
	{
		fadeScreen.enabled = true;
		fadeAmount += Time.deltaTime;
		fadeScreen.color = new Color (0,0,0,fadeAmount);
		if(fadeAmount >= 2)
		{
			SceneManager.LoadScene("GameOver");
		}
	}

	void GameWin()
	{		
		fadeScreen.enabled = true;
		fadeAmount += Time.deltaTime;
		fadeScreen.color = new Color (1,1,1,fadeAmount);
		if(fadeAmount >= 2)
		{
			SceneManager.LoadScene("WinScene");
		}
	}
}
