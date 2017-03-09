using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit1 : MonoBehaviour {
    //public Grid grid;
	// Use this for initialization
	void Start () {
		Scene newScene = SceneManager.GetSceneByName ("SmallEnemy");
		bool didWork = SceneManager.SetActiveScene(newScene);
		Debug.Log("" + didWork);
	}

	// Update is called once per frame
	void Update () {
            if (Input.GetKey(KeyCode.Space))
            {
                Scene testScene = SceneManager.GetSceneByName("Kingdom1_Lvl1");
                //SceneManager.LoadScene ("Prototype_ONE", LoadSceneMode.Single);
                SceneManager.UnloadSceneAsync("SmallEnemy");
            }
        
	}
}
