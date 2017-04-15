using UnityEngine;
using System.Collections;

public class obstacleScript : MonoBehaviour {

	public float obstacleSpeed = 10;

	private gameController gameCon;
	private AudioSource audioSource ;

	void Start(){
		audioSource = GetComponent<AudioSource >();

		GameObject gameControllerObject = GameObject.FindWithTag("GameController");

		if (gameControllerObject != null) {

			gameCon = gameControllerObject.GetComponent<gameController> ();
		}

		if (gameControllerObject == null) {

			Debug.Log ("Cannot find 'GameController' Script");
		}

	}
	void Update(){
	
		transform.Translate (Vector2.down * obstacleSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Boundary")
			Destroy (gameObject);
		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
			audioSource.Play ();
			Debug.Log ("Lost Audio");
			gameCon.GameOver();
		}

	}

}
