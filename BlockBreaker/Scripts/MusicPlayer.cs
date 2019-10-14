using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	static MusicPlayer instance = null;

	// Use this for initialization
	void Start () {
		if (instance != null) {
			Destroy (gameObject);
			print ("Deplicate Music Self Destruct");
		}
		else {
		instance = this;
		GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
