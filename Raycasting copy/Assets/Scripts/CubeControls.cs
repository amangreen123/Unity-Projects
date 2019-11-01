using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControls : MonoBehaviour {

	public float horz;
	public float vert;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horzInput = Input.GetAxis ("Horizontal");
		float vertInput = Input.GetAxis ("Vertical");
		Vector3 forceToAdd = new Vector3 (horzInput * horz, vertInput * vert, 0);
		rb.AddForce (forceToAdd);
	
	}

}
