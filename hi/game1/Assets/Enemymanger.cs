using UnityEngine;
using System.Collections;

public class Enemymanger : MonoBehaviour {
    public PlayerHealth playerhealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnpoints;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	void Spawn()
    {
        if (playerhealth.currentHealth <= 0f)
        {
            return;
        }
        int spawnPointIndex = Random.Range(0, spawnpoints.Length);
        Instantiate(enemy, spawnpoints[spawnPointIndex].position, spawnpoints[spawnPointIndex].rotation);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
