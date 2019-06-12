using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResetScoreScript : MonoBehaviour {

	public MyScore myScore;
	public TextMeshProUGUI pointsScore;

	
	void Start () 
	{
		myScore.score = 0;
		pointsScore.text = myScore.highscore.ToString();
	}

}
