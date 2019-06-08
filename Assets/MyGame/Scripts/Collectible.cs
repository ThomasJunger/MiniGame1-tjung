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

	private void Update()
	{
		pointsScore.text = score.score.ToString();
	}


	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Triggerevent " + collision.gameObject.name);

		if (gameObject.name == "Player" && collision.gameObject.tag == "Egg")
		{
			score.score += 5;
			Debug.Log("scoreplayer " + score.score);
			pointsScore.text = score.score.ToString();
		}
		else if (gameObject.name == "GedachteLinie" && collision.gameObject.tag == "Egg")
		{
			score.score -= 10;
			Debug.Log("scoregedachtelinie " + score.score);
			pointsScore.text = score.score.ToString();
		}

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("ColliosionEvent");
	}
}
