using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public GameObject enemyPrefab;
	public float spawnDist;
	private int enemyNum;
	int maxTime;
	private float timer;

	// Use this for initialization
	void Start () {
		maxTime = 5;
		enemyNum = 5;
		timer = 0;	
		for (int i = 0; i < enemyNum; i++) {
			spawnEnemy ();
		}

	}
	
	// Update is called once per frame
	void Update () {
		int enemieAlive = GameObject.FindGameObjectsWithTag ("Enemy").Length;
		if(enemieAlive == 0){
			timer += Time.deltaTime;
		}


		if (enemieAlive == 0 && timer >= maxTime) {
			enemyNum  += 5;
			timer = 0;

			for (int i = 0; i < enemyNum; i++) {


				spawnEnemy ();

			}
		}
			
	}

	  void spawnEnemy(){
			float angle = Random.Range (0,	Mathf.PI * 2);
			float xOffset = Mathf.Cos (angle) * spawnDist;
			float zOffset = Mathf.Sin (angle) * spawnDist;
			Vector3 enemyPos = transform.position + new Vector3(xOffset,0,zOffset);
			Instantiate (enemyPrefab, enemyPos, Quaternion.identity);
		}

}