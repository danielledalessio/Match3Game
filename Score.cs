using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text text;
	protected int currentscore; 

	void Awake()
	{
		text = GetComponent<Text> ();
	}

	public virtual void OnPieceCleared(GamePiece piece)
	{
		currentscore += piece.score;
		text.text = "Score: " + currentscore;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
