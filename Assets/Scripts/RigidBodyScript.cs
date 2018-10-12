using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyScript : MonoBehaviour {

	Vector2 force = new Vector2(1,2); //force vector so object can be moved

	private Rigidbody2D rb;
	
	// Use this for initialization
	void Start ()
	{

		rb = GetComponent<Rigidbody2D>(); // gets reference to rigid body component of object 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		rb.AddForce(force); // apply force to object as game runs
		Debug.DrawRay(transform.position, force); //shows segment to visualize the force
		Debug.Log("Force = " +force.magnitude);
	}
}
