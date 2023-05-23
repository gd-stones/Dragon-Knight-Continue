using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnailEnemy : MonoBehaviour
{
    [SerializeField] protected float damage;

    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {

    //        if (collision.GetComponent<Transform>().position.y > -0.3f)
    //        {
    //            StartCoroutine(MoveObjectToRight(gameObject, 1f));
    //        }
    //        else
    //        {
    //            collision.GetComponent<Health>().TakeDamage(damage);
    //        }
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //SnailMovement.die = true;
            if (collision.gameObject.GetComponent<Transform>().position.y > -0.38f)
            {
                transform.GetComponent<SnailMovement>().die = true;
                StartCoroutine(MoveObjectToRight(gameObject, 2.5f));
            }
            else
            {
                collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            }
        }
    }

    IEnumerator MoveObjectToRight(GameObject objectToMove, float speed)
    {
        float distanceToMove = speed * Time.deltaTime;
        float elapsedTime = 0f;

        while (elapsedTime < 12f)
        {
            objectToMove.transform.Translate(Vector3.right * distanceToMove);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        objectToMove.SetActive(false);
    }
}
