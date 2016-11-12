using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {home, cell, mirror, sheets_0, lock_0, cell_mirror, cell_mirror_punch, sheets_1, Run, Kick, Freedom, Lose};
	private States myState;

	// Use this for initialization
	void Start () {
	
		text.text = "Welcome to Jail\n\nClick Enter to Start";
		
		myState = States.home;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.home) {
			home();
		}
		else if (myState == States.cell) {
			state_cell();
		}
		else if (myState == States.sheets_0) {
			state_sheets_0();
		}
		else if (myState == States.lock_0) {
			state_lock_0();
		}
		else if (myState == States.cell_mirror) {
			state_cell_mirror();
		}
		else if (myState == States.cell_mirror_punch) {
			state_cell_mirror_punch();
		}
		else if (myState == States.sheets_1) {
			state_sheets_1();
		}
		else if (myState == States.Run) {
			state_Run();
		}
		else if (myState == States.Kick) {
			state_Kick();
		}
		else if (myState == States.Freedom) {
			state_Freedom();
		}
		else if (myState == States.Lose) {
			state_Lose();
		}
	
	}
	
	void home () {
	
		text.text = "Welcome to Jail\n\nClick Enter to Start";

		
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown (KeyCode.Return)){
			myState = States.cell;
		}	
	}
	
	void state_cell () {
			text.text = "You are in a prison cell. There are some " +
						"dirty sheets, a mirror, and a lock on the door." +
						"\n\n Press S to view Sheets, M to view Mirror and L " + 
						"to view Lock";
		
		
		if (Input.GetKeyDown (KeyCode.S)){
			myState = States.sheets_0;
		}
		else if (Input.GetKeyDown (KeyCode.L)){
			myState = States.lock_0;
		}
		else if (Input.GetKeyDown (KeyCode.M)){
			myState = States.cell_mirror;
		}
		
		
	}
	void state_sheets_0 () {
		text.text = "Your sheets are dirty. Please wash them! " +
			"Ewww... smells nasty... Prison life I guess :)" +
				"\n\n Press R to Return to roaming your cell";
		
		
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.cell;
		}
	}
	void state_lock_0 () {
		text.text = "What are you doing... It's locked! " +
					"You could try not being stupid and think of a way out!" +
					"\n\n Press R to Return to roaming your cell";
			
			
		if (Input.GetKeyDown (KeyCode.R)){
				myState = States.cell;
		}
		
	}
	void state_cell_mirror () {
		text.text = "No Way... Its a mirror! " +
					"You could try Punching it if you want?" +
					"\n\n Press R to Return to roaming your cell"+
					"\n Press P to Punch the mirror";
		
		if (Input.GetKeyDown (KeyCode.R)){
			myState = States.cell;
		}
		if (Input.GetKeyDown (KeyCode.P)){
			myState = States.cell_mirror_punch;
		}
		
	}
	void state_cell_mirror_punch () {
	
		text.text = "You cut your knuckels.. Good Job. " +
					"Wipe it up with your sheets will ya!" +
					"\n\n Press S to wipe it up with your Sheets";
				
		
		if (Input.GetKeyDown (KeyCode.S)){
			myState = States.sheets_1;
		}
		
	}
	void state_sheets_1 () {
		
		text.text = "The guard notices and brings you to the " +
					"jail doctor" +
					"\n\n Press Enter to Continue";
		
		
		if (Input.GetKeyDown (KeyCode.Return)){
			myState = States.Run;
		}
		
	}
	void state_Run () {
		
		text.text = "You notice the guard looking away. " +
					"You start to run!" +
					"\n\n Press Enter to Continue";
		
		
		if (Input.GetKeyDown (KeyCode.Return)){
			myState = States.Kick;
		}
	}
		
		void state_Kick () {
			
			text.text = "You have one guard standing in your way " +
						"of freedom. What do you do?" +
						"\n\n Press K to Kick him"+
						"\n Press P to Punch him";
			
			
			if (Input.GetKeyDown (KeyCode.K)){
				myState = States.Freedom;
			}
			if (Input.GetKeyDown (KeyCode.P)){
				myState = States.Lose;
			}
		}
		void state_Lose () {
			
			text.text = "The guard catches your punch " + 
						"and flying headbutts you! \n YOU DIE! \n YOU LOSE! \n\n" + 
						"Click Enter to Re-Start";
			
			if (Input.GetMouseButtonDown(0) || Input.GetKeyDown (KeyCode.Return)){
				myState = States.home;
			}	
		}
	
	void state_Freedom () {
		
		text.text = "YOU NIJA KICK THE CRAP OUT OF HIM! \n " +
					"What will you do with your freedom?" +
				"\n\n Click Enter to Re-Start";
		
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown (KeyCode.Return)){
			myState = States.home;
		}	
		
	}
}



