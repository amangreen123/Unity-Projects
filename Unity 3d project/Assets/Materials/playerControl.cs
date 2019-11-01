using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {

	public Rigidbody rb;
	public float moveSpeed;
	private Vector3 startPos; 


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		startPos = transform.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 moveForce = new Vector3 (0, 0, 0);

		moveForce.x = Input.GetAxis ("Horizontal") * moveSpeed;
		moveForce.z = Input.GetAxis ("Vertical") * moveSpeed;

		rb.AddForce (moveForce);
	}

	void OnCollisionEnter(Collision col){

		if(col.gameObject.tag == "Finish"){
			Destroy (gameObject);
			Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "Statue") {
			transform.position = new Vector3(-13.98f,.86f,-13.45f);
			Debug.Log ("hit");

		}
		//always use debug.log to check collision
		Debug.Log (col.gameObject.tag);
	}
}