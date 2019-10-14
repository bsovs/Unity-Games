using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Paddle Paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
	
		paddleToBallVector = this.transform.position - Paddle.transform.position;
		print (paddleToBallVector);
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
		//Lock ball to paddle on Game Start
		this.transform.position = Paddle.transform.position + paddleToBallVector;
		//Wait for Mouse Press
		if (Input.GetMouseButton(0)){
			print ("Launch Ball");
			hasStarted = true;
			this.rigidbody2D.velocity = new Vector2 (50f, 700f);
			}
		}
	}
	
	void OnCollisionEnter2D (Collision2D Collision) {
		if (hasStarted) {
		audio.Play ();
		}
	}
}
