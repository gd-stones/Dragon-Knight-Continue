using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttack>().Attack();
    }
}