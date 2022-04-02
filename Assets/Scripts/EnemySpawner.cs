using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject pfEnemy;
    [SerializeField] private float timeBetweenSpawn=2.0f;
    [SerializeField] private float timeBetweenSpawnDecrease = 0.1f;
    [SerializeField] private float minTimeBetweenSpawn = 0.3f;

    private float spawnTimer;

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer < 0)
        {
            spawnTimer += timeBetweenSpawn;
            timeBetweenSpawn -= timeBetweenSpawnDecrease;
            if (timeBetweenSpawn < minTimeBetweenSpawn) timeBetweenSpawn = minTimeBetweenSpawn;

            Vector3 spawnPosition = new Vector3(Random.Range(-25, 25), 20, 0);
            Instantiate(pfEnemy,spawnPosition,Quaternion.identity);
        }
    }
}
