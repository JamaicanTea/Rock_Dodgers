using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertShooter : MonoBehaviour {
	public GameObject projectile;
	public GameObject shootingPanel;
	public float projSpeed = 10f;
	public float shootTime =0f;
	public float shootDelay =1.5f;
	// Use this for initialization
	void Start () 
	{

		InvokeRepeating ("Shoot", shootTime, shootDelay);	
	}
	
	void Shoot () 
	{
		GameObject projPrefab = Instantiate (projectile, shootingPanel.transform.position, transform.rotation);
		Rigidbody rb = projPrefab.GetComponent<Rigidbody> ();
		Vector3 randomPos = new Vector3 (Random.Range(-34.1f, 37f), transform.position.y,Random.Range(-43f, 35f));
		projPrefab.transform.position = randomPos;
		rb.velocity = Vector3.down * projSpeed;	
	}
}
