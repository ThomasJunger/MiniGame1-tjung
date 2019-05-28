using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour {

private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.name == "ColliderBottom")
		{
			Destroy(gameObject);
		}
	}
}