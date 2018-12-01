using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCurrent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadCurrentScene()
	{
		Debug.Log ("Scene Loaded");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

}


