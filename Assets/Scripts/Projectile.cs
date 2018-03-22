using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
	public float minZ = -57.1f;
	public float minX = -40.1f;
	public float minY = -2f;

	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.z < minZ||transform.position.x < minX || transform.position.y< minY) 
		{
			Destroy (gameObject);
		}
	}
}
