using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
		{

	public Rigidbody rb;

	public float speed;
	public float rayDist;
	public float rotSpeed;
	public float health;
	public Slider healthbar;
	//public Animator anim;

	private int score;



	public Text curValueText;





	// Use this for initialization
	void Start ()
	{
		score = 0;
		healthbar.value = health;
	
	}
	
	// Update is called once per frame

    void FixedUpdate ()
	{
		float xInput = Input.GetAxis ("Horizontal");
		float yInput = Input.GetAxis ("Vertical");
	      
		Vector3 moveVal = new Vector3 (xInput * speed, 0, yInput * speed);
		rb.AddForce (moveVal);
		//Debug.Log ("move: " + moveVal);
	}

	void Update ()
	{
		Vector3 rayStart = transform.position + new Vector3 (0, -0.2f, 0);
		Vector3 rayDir = transform.forward;
		//float rotationToAdd = rotSpeed * xInput * Time.deltaTime;
		//transform.Rotate(new Vector3(0,rotationToAdd,0);



		Debug.DrawRay (rayStart, rayDir * rayDist, Color.green);
	    
		if (Input.GetButtonDown ("Jump") == true) {
			RaycastHit hit;
			Physics.Raycast (rayStart, rayDir, out hit, rayDist);

			if (hit.collider != null) {
				//Debug.Log ("ray hit" + hit);
			
				if (hit.collider.tag == "Enemy") {
					//anim.GetBool ("Attack");
					Destroy (hit.collider.gameObject);

					score++;
						}
			}

		
		}

	  
		healthbar.value = health;
		updateText ();
	}

	public void Damage(float damageAmount){
		health -= damageAmount;

		if(health <= 0) {
			Destroy (gameObject);
			UnityEngine.SceneManagement.SceneManager.LoadScene ("GameOver");
		}
	}

	void updateText ()
	{
		curValueText.text = "Score: " + score;
	}
}