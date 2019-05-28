using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEgg : MonoBehaviour {

	public Egg eggPrefab;
	public GameObject EggParent;
	private bool spawn = true;

	public float minSpawnDelay = 1.0f;
    public float maxSpawnDelay = 5.0f;

	public float eggMinSize = 0.05f;
	public float eggMaxSize = 0.05f;

	public int xMinPos;
	public int xMaxPos;


	IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            EggSpawn();
        }
	}

	private void EggSpawn()
	{
	float eggSize = Random.Range(eggMinSize, eggMaxSize);
	Egg eggClone = (Egg)Instantiate(eggPrefab, transform.position, transform.rotation);
	eggClone.transform.SetParent(EggParent.transform);
	eggClone.transform.localPosition = new Vector3(Random.Range(xMinPos, xMaxPos), EggParent.transform.position.y, 0f);
	eggClone.transform.localScale = new Vector3(eggSize, eggSize, 0);
	eggClone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2, 2), Random.Range(-10, -1));

	}
}
