using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyScript : MonoBehaviour {

	// direction of the force
	Vector2 forceDirection = new Vector2(1,2); 
	
	// desired strength of applied force
	float desiredMagnitude = 2; 
	
	Vector2 force;

	private Rigidbody2D rb;
	
	void Start ()
	{

		rb = GetComponent<Rigidbody2D>(); // gets reference to rigid body component of object 
		force = desiredMagnitude * forceDirection.normalized; // normalize the direction, and then multiply by the desired magnitude
		Debug.DrawRay(transform.position, force); //shows segment to visualize the force
		Debug.Log("Force = " +force.magnitude);
		
	}
	
	void Update () {
		
		rb.AddForce(force); // apply force to object as game runs
		
	}
}
