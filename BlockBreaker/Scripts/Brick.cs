using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	private LevelManager levelmanager;
	private bool isBreakable;
	
	public int maxHits;
	public int timesHit;
	public static int breakableCount = 0;
	public Sprite[] hitSprites;


	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	
	if (isBreakable) {
		breakableCount++;
		
	}
	
		timesHit = 0;
		maxHits = 2;
		
	}
	
	// Update is called once per frame
	void Update () {
		//Destroy Bricks
		
}

	void SimulateWin () {
		levelmanager.LoadNextLevel();
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		//Count Hits
		timesHit++;
		
		if (timesHit >= maxHits) {
			print ("Boom!");
			Destroy (gameObject);
			breakableCount--;
			levelmanager.BrickDestroyed();
		}
		else {
			LoadSprites();
		}
	}
	
	void LoadSprites () {
	 int spriteIndex = timesHit - 1;
	 this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
	
}




