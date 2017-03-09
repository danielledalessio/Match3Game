using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySmall : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject == player) {
			SceneManager.LoadScene ("SmallEnemy", LoadSceneMode.Additive);
			Destroy (gameObject);
			Debug.Log ("Fighting");
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
