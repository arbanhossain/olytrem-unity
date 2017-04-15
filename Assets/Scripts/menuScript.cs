using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public void OnClicked(){

		SceneManager.LoadScene ("menu");
	}
}
