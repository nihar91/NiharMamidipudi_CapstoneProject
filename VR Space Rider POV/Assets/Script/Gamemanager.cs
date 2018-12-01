using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour 
{
	public static Gamemanager instance = null;

	public GameObject scoreTextObject;

	int score;
	Text scoreText;


	void Awake	()
	{
	 
		if (instance == null)
			instance = this;
		else if (instance != null) 
			Destroy (gameObject);

		scoreText = scoreTextObject.GetComponent<Text> ();
		scoreText.text = "Score: " + score.ToString (); 
	}

	public void Collect(int passedValue, GameObject passedObject)
	{
		passedObject.GetComponent<Renderer> ().enabled = false;
		Destroy (passedObject, 1.0f); 
		score = score + passedValue; 
		scoreText.text = "Score: " + score.ToString (); 
	
	
	}



}
