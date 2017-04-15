using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playScript : MonoBehaviour {

	public void OnClicked(){
	
		SceneManager.LoadScene ("main");
	}
}
