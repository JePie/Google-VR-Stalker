using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Delay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(delay(3.0f));

	}

	// Update is called once per frame
	void Update () {

	}
	public void LoadScene(int SceneIndex){

		SceneManager.LoadScene (SceneIndex);
	}
	IEnumerator delay(float time){
		yield return new WaitForSeconds(time);
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}


}