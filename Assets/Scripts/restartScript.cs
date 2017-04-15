using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartScript : MonoBehaviour {

	public void OnClicked(){
	
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}
}
