using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {
	public float moveSpeed = 1000f;
	Rigidbody rb;
	Animator anim;
	public bool moveForward = false;
	public bool moveSides = false;
	public float moveBonus = 300f;
	public int lives = 3;
	Coroutine co;
	public GameObject gameOver;
	public GameObject menuButton;
	public GameObject retryButton;
	public Text lifeDisplay;
	Coroutine invuln;
	public CapsuleCollider collie;


	// Use this for initialization
	void Awake ()
	{
		Time.timeScale = 1;
	}
	void Start () 
	{
		collie = GetComponent<CapsuleCollider> ();
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
		lifeDisplay.text = "Lives: " + lives;
		gameOver.gameObject.SetActive (false);
		menuButton.gameObject.SetActive (false);
		retryButton.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () //movement script
	{
		if (Input.GetKey (KeyCode.W)) 
		{
			rb.velocity = Vector3.forward * moveSpeed * Time.deltaTime * 60;// moves player at the direction and activates bool
			moveForward = true;
		}
		else if (Input.GetKeyUp (KeyCode.W))// removes bool for animation
		{
			moveForward = false;
		}

		if (Input.GetKey (KeyCode.A)) 
		{
			rb.velocity = Vector3.left * moveSpeed * Time.deltaTime * 60;
			moveSides = true;
		}
		else if (Input.GetKeyUp (KeyCode.A)) 
		{
			moveSides = false;
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			rb.velocity = Vector3.back * moveSpeed * Time.deltaTime * 60;
			moveForward = true;
		} 
		else if (Input.GetKeyUp (KeyCode.S)) 
		{
			moveForward = false;
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			rb.velocity = Vector3.right * moveSpeed * Time.deltaTime * 60;
			moveSides = true;
		}
		else if (Input.GetKeyUp (KeyCode.D)) 
		{
			moveSides = false;
		}

		if (Input.GetKeyDown (KeyCode.Space) && moveForward == true) 
		{
			anim.SetTrigger("RollNow");
			co = StartCoroutine (SpeedBoost ());


		}
		if (Input.GetKeyDown (KeyCode.Space) && moveSides == true) 
		{
			anim.SetTrigger("RollSideNow");
			co = StartCoroutine (SpeedBoost ());

		}
		if (lives == 0) 
		{
			gameOver.gameObject.SetActive (true);
			menuButton.gameObject.SetActive (true);
			retryButton.gameObject.SetActive (true);
			Time.timeScale = 0;
		}



	}

	void OnTriggerEnter (Collider player) 
	{
		if (player.CompareTag ("Projectile")) 
		{
			lives--;
			UpdateLifeDisplay ();
			invuln = StartCoroutine (Invulnerability());
		}
	}

	void UpdateLifeDisplay ()
	{
		lifeDisplay.text = "Lives: " + lives;
	}

	IEnumerator SpeedBoost()
	{
		moveSpeed = moveSpeed+moveBonus;
		yield return new WaitForSeconds (3.5f);
		moveSpeed = moveSpeed-moveBonus;

		co = null;
	}
	IEnumerator Invulnerability ()
	{
		collie.enabled = false;
		rb.useGravity = false;
		print ("ow!");
		yield return new WaitForSeconds (1.5f);
		print ("k im fine!");
		collie.enabled = true;
		rb.useGravity = true;
	}
}
