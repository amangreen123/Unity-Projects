using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
	//https://www.youtube.com/watch?v=latJCft3GSo
	public float outofBounds = -20;
	public Vector3 spawnlocation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y <= outofBounds) {
			transform.position = spawnlocation;
		}
	}
}
