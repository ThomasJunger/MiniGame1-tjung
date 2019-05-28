using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingRandomizer : MonoBehaviour {

	private float rndVal;
	private float rndVal2;
	public float minValX = -6f;
	public float maxValX = 6f;
	private System.Random rndSys = new System.Random();

	// Use this for initialization
	void Start () {
		rndVal = rndSys.Next(0, 10);
		rndVal2 = UnityEngine.Random.Range(4, 100);
		Debug.Log("System Random " + rndVal + " Unity Random " + rndVal2);
		

	}

	public void ChangeRandomCube()
	{
		gameObject.transform.position = new Vector3(UnityEngine.Random.Range(minValX,maxValX), 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
