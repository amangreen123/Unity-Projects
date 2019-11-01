using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatestar: MonoBehaviour {
	//http://www.lessmilk.com/tutorial/space-shooter-unity-1 image from zip file on this site
	//https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial/creating-collectable-objects?playlist=25844
	void Start () {
		
	}
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);

	}
}
