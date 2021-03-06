using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public Level level;

	public UnityEngine.UI.Text remainingText;
	public UnityEngine.UI.Text targetText;
	public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Text winText;
    public UnityEngine.UI.Text loseText;

    private bool isGameOver = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetScore(int score)
	{
		scoreText.text = score.ToString ();

	}

	public void SetTarget(int target)
	{
		targetText.text = target.ToString ();
	}

	public void SetRemaining(int remaining)
	{
		remainingText.text = remaining.ToString ();
	}

	public void SetRemaining(string remaining)
	{
		remainingText.text = remaining;
	}



	public void OnGameWin()
	{
        winText.text = ("You won!");
	}

	public void OnGameLose()
	{
        loseText.text = ("You lost!");
	}
}
