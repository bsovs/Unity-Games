using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
	
		float mousePosInBlocks = Input.mousePosition.x / Screen.width *1050;
		
		paddlePos.x = Mathf.Clamp (mousePosInBlocks, 80f, 740f);
		
		this.transform.position = paddlePos;
	}
}
