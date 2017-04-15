using UnityEngine;
using System.Collections;

public class carScript : MonoBehaviour {

	public float speed = 20;

	public string axis;


	void Update()
	{
		float h = Input.GetAxisRaw(axis);
		GetComponent<Rigidbody2D>().velocity = new Vector2(h, 0) * speed;
		

	}
}
