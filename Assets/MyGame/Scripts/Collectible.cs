using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour 
{
	
	public MyScore score;
	private TextMeshProUGUI pointsScore;

	void Start()
	{
		pointsScore = GameObject.Find("PointScore").GetComponent<TextMeshProUGUI>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Triggerevent " + collision.gameObject.name);

		if (collision.gameObject.name == "Player")
		{
			score.score += 1;
			Debug.Log("scoreplayer " + score.score);
			pointsScore.text = score.score.ToString();
		}
		else if (collision.gameObject.name == "GedachteLinie")
		{
			score.score -= 2;
			Debug.Log("scoregedachtelinie " + score.score);
			pointsScore.text = score.score.ToString();
		}

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("ColliosionEvent");
	}
}
