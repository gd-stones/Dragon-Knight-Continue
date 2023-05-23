using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<Transform>().position.y > (transform.position.y + 0.8f))
            {
                gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                gameObject.GetComponent<Health>()?.TakeDamage(damage);
                //print(gameObject);
            }
            else
            {
                collision.gameObject.GetComponent<Health>()?.TakeDamage(damage);
            }

            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else if (collision.gameObject.CompareTag("Snail"))
        {
            gameObject.GetComponent<Health>()?.TakeDamage(damage);
        }
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>()?.TakeDamage(damage);
        }
    }
}
