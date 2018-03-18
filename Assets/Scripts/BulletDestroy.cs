using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Projectile") 
		{
			Destroy(gameObject);
		}
	}
	

}
