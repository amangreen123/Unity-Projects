using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner: MonoBehaviour {

	public GameObject Objspawner;
	GameObject Spawner;


	// Use this for initialization
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space) == true) {

			Vector3 spawnPos = transform.position;
			spawnPos.x += Random.Range (-0.5f, 0.5f);
			spawnPos.z += Random.Range (-0.5f, 0.5f);
			Spawner = Instantiate (Objspawner, transform.position, Quaternion.identity)as GameObject;
	
			// Update is called once per frame

		}
	}
}
