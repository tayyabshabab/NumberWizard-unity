using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		GameStart();
	}
	
	void GameStart() {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don´t tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");
		
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			UpdateGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			UpdateGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won");
			GameStart();
		}
	}
	
	void UpdateGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
	}
}
