using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public float score = 0f;
	public float scoreInc = 10f;
	public Text scoreText;
	public GameObject horiShooter;
	public GameObject vertShooter;
	public GameObject ground;
	public Animator anim;


	// Use this for initialization
	void Start () 
	{
		scoreText.text = "Score :" + score;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		score += Time.deltaTime * scoreInc;
		DisplayScore ();
		if (score > 100) 
		{
			horiShooter.gameObject.SetActive (true);
		}
		if (score > 200) 
		{
			vertShooter.gameObject.SetActive (true);
		}
		if (score> 500)
		{
			ground.transform.localScale = -new Vector3 (29f, 20f, 29f);
		}
		if (score> 700)
		{
			ground.transform.localScale = -new Vector3 (23f, 20f, 23f);
		}
		if (score> 900)
		{
			ground.transform.localScale = -new Vector3 (19f, 20f, 19f);
		}
		if (score > 1100) 
		{
			ground.transform.localScale = -new Vector3 (16f, 20f, 16f);
		}
		if (score > 1300) 
		{
			ground.transform.localScale = -new Vector3 (15f, 20f, 15f);
			anim.SetTrigger("MovePlatform");

		}
	
	}

	void DisplayScore ()
	{
		scoreText.text = "Score :" + score.ToString("#####");
	}
}
