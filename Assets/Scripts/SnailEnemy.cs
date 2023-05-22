using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnailEnemy : MonoBehaviour
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            if (collision.GetComponent<Transform>().position.y > -0.3)
            {
                //gameObject.GetComponent<BoxCollider2D>().enabled = false;
                StartCoroutine(MoveObjectToRight(gameObject, 1f, collision));
            }
            else
            {
                collision.GetComponent<Health>().TakeDamage(damage);
            }

            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }

    IEnumerator MoveObjectToRight(GameObject objectToMove, float speed, Collider2D collision)
    {
        float distanceToMove = speed * Time.deltaTime;
        float elapsedTime = 0f;

        while (elapsedTime < 2f)
        {
            objectToMove.transform.Translate(Vector3.right * distanceToMove);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        objectToMove.SetActive(false);
    }
}
