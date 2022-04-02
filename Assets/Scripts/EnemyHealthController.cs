using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    [SerializeField] private int totalHealth = 3;
    [SerializeField] private GameObject deathEffect;

    public void Damage(int damageAmount)
    {
        totalHealth -= damageAmount;
        if (totalHealth <= 0)
        {
            if (deathEffect != null)
            {
                Instantiate(deathEffect,transform.position,Quaternion.identity);
            }
            // TODO: Audio
            Destroy(gameObject);
        }
    }
}
