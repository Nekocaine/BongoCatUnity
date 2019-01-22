using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnner : MonoBehaviour {

    public float spawnTime = 10f;
    float timeUntilSpawn;
    public bool hasLost = false;
    public GameObject drum;
    public Text GameOver;
    int nb;

	// Use this for initialization
	void Start () {
        timeUntilSpawn = spawnTime;
	}

    public void drumDetroyed()
    {
        nb--;
    }
	
	void FixedUpdate () {
        spawnTime -= 0.0005f;
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn < 0)
        {
            Vector2 pos = new Vector2(Random.Range(-8f,8f), Random.Range(-4f, 4f));
            GameObject spawned = Instantiate(drum);
            spawned.transform.position = pos;
            timeUntilSpawn = spawnTime;
            nb++;
            if (nb > 30)
            {
                Time.timeScale = 0;
                GameOver.color = new Color(0, 0, 0, 255);
                hasLost = true;
            }
        }
	}
}
