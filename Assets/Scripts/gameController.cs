using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

	public GameObject obstacle;
	public GameObject coin;
	public Vector2 spawnValues;
	public float spawnWait;
	public int obstacleCount;
	public float startWait;
	public float coinWait;
	int playerScore;
	public Text scoreText;
	public GameObject buttonMenu;
	public GameObject buttonReplay;
	public GameObject gameOverBg;
	public GameObject gameOverText;
	public Text lastText;
	public GameObject gameComponents;
	public GameObject car;

	void Start(){
		car.SetActive (false);
		car.SetActive (true);

		buttonMenu.SetActive(false);
		buttonReplay.SetActive(false);
		gameOverBg.SetActive(false);
		gameOverText.SetActive(false);

		playerScore = 0;

		StartCoroutine (SpawnObstacles());
		StartCoroutine (SpawnCoins ());
	}

	void Update(){
	
	
	}

	IEnumerator SpawnObstacles(){
		
		yield return new WaitForSeconds (startWait);

		for (int i = 0; ; i++) {
			Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (obstacle, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (spawnWait);
		}
	}

	IEnumerator SpawnCoins(){
		
		yield return new WaitForSeconds (startWait);

		for (int i = 0; ; i++) {
			Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (coin, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (coinWait);
		}
	}

	public void AddScore(){
		playerScore++;
		UpdateScoreText ();
	}

	public void UpdateScoreText(){
		scoreText.text = playerScore.ToString();
	}

	public void GameOver(){
	
		buttonMenu.SetActive(true);
		buttonReplay.SetActive (true);
		gameOverBg.SetActive(true);
		gameOverText.SetActive(true);
		gameComponents.SetActive(false);
		lastText.text = scoreText.text;
		Destroy(gameObject);
	}
}
