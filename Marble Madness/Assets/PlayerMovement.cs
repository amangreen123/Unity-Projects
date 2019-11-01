using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	//https://www.youtube.com/watch?v=7C7WWxUxPZE
	// Use this for initialization
	void Start  () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
	
		float xInput = Input.GetAxis ("Horizontal") * Time.deltaTime; 
		float yInput = Input.GetAxis ("Vertical") * Time.deltaTime;

		Vector3 movement = new Vector3 (xInput, 0.0f, yInput);
		rb.AddForce (movement*speed);
	}
}
