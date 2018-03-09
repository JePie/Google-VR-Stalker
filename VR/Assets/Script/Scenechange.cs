using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
            LoadScene(2);
    }
    public void LoadScene(int SceneIndex){

		SceneManager.LoadScene (SceneIndex);
	}

}
