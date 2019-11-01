using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {
	public GameObject objToFollow;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 objPos = objToFollow.transform.position;
		Vector3 myPos = objPos + offset;
		transform.position = myPos;
	}
}
