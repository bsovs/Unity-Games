using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {


	void Start () {
		
	}

	public void LoadLevel (string name) {
		Debug.Log("Level load requested for: "+name);
		Application.LoadLevel (name);
		
	}
	public void QuitRequest () {
		Debug.Log("I want to quit");
	}
	public void ReStart(string name) {
		Debug.Log("Level load requested for: "+name);
		Application.LoadLevel (name);
		
	}
	public void LoadNextLevel () {
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	public void BrickDestroyed () {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel ();
		}
	}
	
}

