using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

	private Rigidbody2D rb;
	private int score;
	private int highScore;

	public float maxSpeed;
	public TextMesh scoreText;
	public TextMesh wintext;



	void Start (){
		rb = GetComponent<Rigidbody2D> ();
		score = 0;
		highScore = PlayerPrefs.GetInt ("high_score", 0);
		highScore = 6;
	}

	void Update (){

		if (score > highScore) {
			highScore = score;
			PlayerPrefs.SetInt ("high_score", highScore);
		}
	
		if (Input.GetKeyDown (KeyCode.Escape) == true) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("title");

		}
	}


	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.AddForce (movement * maxSpeed);
		}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Pickup"))
			
		{
			score++;
			scoreText.text = "score" + score;
			other.gameObject.SetActive (false);
		}
	}
			
}
