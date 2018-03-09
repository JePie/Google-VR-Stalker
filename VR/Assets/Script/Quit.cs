using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
			LoadScene (1);
	}
	public void LoadScene(int SceneIndex){

		SceneManager.LoadScene (SceneIndex);
	}
}
