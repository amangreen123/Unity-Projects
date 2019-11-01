using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	public float rayDist;
	private int xDir;

	public Renderer Renderer;

	public Material green;
	public Material blue;
	public Material purple;
	public Material red;
	public Material white;

	// Use this for initialization
	void Start () {
		xDir = 1;

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 startPos = transform.position;
		Vector3 raycastDir = new Vector3(xDir, 0, 0);
		RaycastHit hit; 
		Physics.Raycast(startPos, raycastDir, out hit, rayDist);

		if (hit.collider != null) {
			Debug.Log ("hit " + hit.collider.gameObject);
			Renderer.material = purple;
		} else {
			Renderer.material = white;
		}

		Debug.DrawRay(startPos, raycastDir * rayDist, Color.magenta);

		Vector3 rcDir1 = new Vector3(0, xDir, 0);
		RaycastHit hit1; 
		Physics.Raycast(startPos, rcDir1, out hit1, rayDist);

		if (hit1.collider != null) {
			Debug.Log (" hit " + hit1.collider.gameObject);
			Renderer.material = blue;
		}

		Debug.DrawRay(startPos, rcDir1 * rayDist, Color.blue);

		Vector3 rcDir2 = new Vector3(xDir * -1, 0, 0);
		RaycastHit hit2; 
		Physics.Raycast(startPos, rcDir2, out hit2, rayDist);

		if (hit2.collider != null) {
			Debug.Log (" hit " + hit2.collider.gameObject);
			Renderer.material = red;
		}

		Debug.DrawRay(startPos, rcDir2 * rayDist, Color.red);

		Vector3 rcDir3 = new Vector3(0, xDir * -1, 0);
		RaycastHit hit3; 
		Physics.Raycast(startPos, rcDir3, out hit3, rayDist);

		if (hit3.collider != null) {
			Debug.Log (" hit " + hit3.collider.gameObject);
			Renderer.material = green;
		}
			
		Debug.DrawRay(startPos, rcDir3 * rayDist, Color.green);

	}

}
