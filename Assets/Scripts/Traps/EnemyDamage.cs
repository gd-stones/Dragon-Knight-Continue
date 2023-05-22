using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //collision.GetComponent<Health>().TakeDamage(damage);
            if (collision.GetComponent<Transform>().position.y > (transform.position.y + 1.2f))
            {
                gameObject.GetComponent<BoxCollider2D>().isTrigger = false; 
                gameObject.GetComponent<Health>().TakeDamage(damage);
                //print(gameObject);
            }
            else
            {
                collision.GetComponent<Health>().TakeDamage(damage);
            }

            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else if (collision.tag == "Snail")
        {
            print("skfjhslfhslfj");
            gameObject.GetComponent<Health>()?.TakeDamage(damage);
        }
    }
}
