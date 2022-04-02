using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private GameObject hitEffect;

    private Rigidbody2D rb;
    private int damageAmount = 1;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject,5f);
    }

    void Update()
    {
        rb.velocity = bulletSpeed * Vector2.up;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealthController>().Damage(damageAmount);
            Debug.Log("Hit an enemy");
        }

        if (hitEffect != null)
        {
            Instantiate(hitEffect, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
