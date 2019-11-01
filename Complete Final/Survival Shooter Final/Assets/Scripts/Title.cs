using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown == true) {
			UnityEngine.SceneManagement.SceneManager.LoadScene("Final Unity Project");
		}

		if (Input.anyKeyDown == true) {
			UnityEngine.SceneManagement.SceneManager.LoadScene("Control Screen");
		}

		if(Input.GetKeyDown(KeyCode.R)){
			UnityEngine.SceneManagement.SceneManager.LoadScene("Final Unity Project");
		}
			
	}
}
