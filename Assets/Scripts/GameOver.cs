using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
	public GameObject gameOver;
	public GameObject menuButton;
	public GameObject retryButton;

	void OnTriggerEnter (Collider go) 
	{
		if(go.CompareTag ("Player"))
		{
			gameOver.gameObject.SetActive (true);
			menuButton.gameObject.SetActive (true);
			retryButton.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
		
	}
}
