using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	public void Reset () 
	{
		Application.LoadLevel ("GameScene");
	}
	
	// Update is called once per frame
	public void MainMenu () 
	{
		Application.LoadLevel ("MainMenu");	
	}
		
	public void PlayGame()
	{
		Application.LoadLevel ("GameScene");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
