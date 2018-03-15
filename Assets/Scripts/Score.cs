using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public float score = 0f;
	public float scoreInc = 10f;
	public Text scoreText;


	// Use this for initialization
	void Start () 
	{
		scoreText.text = "Score :" + score;
	}
	
	// Update is called once per frame
	void Update () 
	{
		score += Time.deltaTime * scoreInc;
		DisplayScore ();
	}

	void DisplayScore ()
	{
		scoreText.text = "Score :" + score.ToString("#####");
	}
}
