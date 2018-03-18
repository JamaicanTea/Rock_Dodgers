using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float minZ = -55.1f;

	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.z < minZ) 
		{
			Destroy (gameObject);
		}
	}
}
