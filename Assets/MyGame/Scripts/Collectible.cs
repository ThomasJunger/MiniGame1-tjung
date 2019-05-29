using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour 
{
	public MyScore score;
	public TextMeshProUGUI pointsScore;

	void Start()
	{
		

	}


	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Triggerevent " + collision.gameObject.name);

		if (collision.gameObject.name == "Player")
		{
			score.score += 5;
			Debug.Log("scoreplayer " + score.score);
			pointsScore.text = score.score.ToString();
		}
		else if (collision.gameObject.name == "GedachteLinie")
		{
			score.score -= 10;
			Debug.Log("scoregedachtelinie " + score.score);
			pointsScore.text = "hallo";
		}

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("ColliosionEvent");
	}
}
