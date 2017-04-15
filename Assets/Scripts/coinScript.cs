using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class coinScript : MonoBehaviour {

	public float coinSpeed = 10;
	private gameController gameCon;
	private AudioSource audioSource ;
	public Sprite bg;

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

		transform.Translate (Vector2.down * coinSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			gameCon.AddScore ();
			audioSource.Play ();
			Debug.Log ("Played Audio");
			GetComponent<SpriteRenderer>().sprite = bg;
		}
		if (col.gameObject.tag == "Boundary")
			Destroy (gameObject);
		if (col.gameObject.tag == "Obstacle")
			Destroy (gameObject);

	}


}
