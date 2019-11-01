using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqSpawner : MonoBehaviour {

	public GameObject sqspawners;
	GameObject squarespawner;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A) == true) {

			Vector3 spawnPos = transform.position;
			spawnPos.x += Random.Range (-0.10f, 0.10f);
			spawnPos.z += Random.Range (-0.10f, 0.10f);
			squarespawner = Instantiate (sqspawners, transform.position, Quaternion.identity)as GameObject;
			}
 }
}
