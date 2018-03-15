using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float moveSpeed = 1000f;
	Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.W)) 
		{
			rb.velocity = Vector3.forward * moveSpeed * Time.deltaTime * 60;
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			rb.velocity = Vector3.left * moveSpeed * Time.deltaTime * 60;
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			rb.velocity = Vector3.back * moveSpeed * Time.deltaTime * 60;
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			rb.velocity = Vector3.right * moveSpeed * Time.deltaTime * 60;
		}

	}
}
