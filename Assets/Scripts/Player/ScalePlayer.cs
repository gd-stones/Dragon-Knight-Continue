using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePlayer : MonoBehaviour
{
    [SerializeField] private float scaleValue;
    [SerializeField] private AudioClip pickupSound;
    private Transform playerScale;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.instance.PlaySound(pickupSound);
            //collision.GetComponent<Health>().AddHealth(healthValue);
            Vector3 scaleChange = new Vector3(scaleValue, scaleValue, scaleValue);
            
            playerScale = collision.gameObject.GetComponent<Transform>();
            //print(playerScale);
            //print (scaleChange);
            playerScale.localScale = scaleChange;

            //print("sfdlhsldf" + playerScale.localScale);

            gameObject.SetActive(false);
        }
    }
}
