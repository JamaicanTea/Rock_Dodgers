using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	public float rotateSpeed = 10f;

	// Use this for initialization
	void Update () 
	{
		transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime*1);
	}
}
