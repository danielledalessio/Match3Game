using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {

	public Grid grid;
	public HUD hud;

	protected int currentScore;
	public bool didWin;

	// Use this for initialization
	void Start () {
		hud.SetScore (currentScore);
	}



	/*Text text;
	void Awake()
	{
		text = GetComponent<Text> ();
	}*/


	public virtual void GameWin()
	{
        didWin = true;
        grid.GameOver();
        hud.OnGameWin();
        Debug.Log("You win!");
        
	}

	public virtual void GameLose()
	{
		Debug.Log ("You lose");
		grid.GameOver ();
        hud.OnGameLose();
		didWin = false;
	}

	public virtual void OnMove()
	{
		Debug.Log ("You moved");
	}

	public virtual void OnPieceCleared(GamePiece piece)
	{
		currentScore += piece.score;
		Debug.Log ("Score: " + currentScore);
		hud.SetScore (currentScore);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
