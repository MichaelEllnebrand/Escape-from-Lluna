using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    [SerializeField] private GameObject deathEffet;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (deathEffet != null)
            {
                Instantiate(deathEffet,transform.position,Quaternion.identity);
            }
            Destroy(gameObject);

            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
