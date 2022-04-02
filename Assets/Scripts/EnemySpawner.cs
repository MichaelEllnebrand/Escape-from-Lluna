using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject pfEnemy;
    [SerializeField] private float timeBetweenSpawn;

    private float spawnTimer;

    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer < 0)
        {
            spawnTimer += timeBetweenSpawn;
            Vector3 spawnPosition = new Vector3(Random.Range(-25, 25), 20, 0);
            Instantiate(pfEnemy,spawnPosition,Quaternion.identity);
        }
    }
}
