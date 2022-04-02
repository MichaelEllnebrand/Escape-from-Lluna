using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 10;
    [SerializeField] private float enemyAcceleration =0.01f;
    private GameObject player;

    void Awake()
    {
        player = GameObject.Find("Player");
        if (player == null)
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {
        enemySpeed += enemyAcceleration * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);
    }
}
