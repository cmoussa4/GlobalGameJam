using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pebble : MonoBehaviour
{
    [SerializeField] GameObject deathexplosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Borders"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(deathexplosion, transform.position, Quaternion.identity);
        }
    }
}
