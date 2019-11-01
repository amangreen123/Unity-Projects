using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscprit : MonoBehaviour {
	//https://opengameart.org/content/medieval-statue

	public Vector3 moveForce;
	public Rigidbody rb;



	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce (moveForce);


	}
	void OnCollisionEnter(Collision info){
		moveForce *= -1;

	}


}
