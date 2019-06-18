using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreLoader : MonoBehaviour {

	public TextMeshProUGUI endScore;
	public TextMeshProUGUI highScore;
	public MyScore myScore;
	
	// Use this for initialization
	void Start () 
	{
	OverwriteHighscore();
	LoadScore();
	}

	public void LoadScore()
	{
	endScore.text = myScore.score.ToString();
	highScore.text = myScore.highscore.ToString();
	}
	
	public void OverwriteHighscore()
	{
		if (myScore.score > myScore.highscore)
		{
			myScore.highscore = myScore.score;
		}
	}
}
