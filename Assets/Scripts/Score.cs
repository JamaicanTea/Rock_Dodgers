using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public float score = 0;
	public float scoreInc = 100;
	public Text scoreText;


	// Use this for initialization
	void Start () 
	{
		scoreText.text = "Score :" + score;
	}
	
	// Update is called once per frame
	void Update () 
	{
		score = Time.time * scoreInc;
		DisplayScore ();
	}

	void DisplayScore ()
	{
		scoreText.text = "Score :" + score;
		score.ToString ("####");
	}
}
