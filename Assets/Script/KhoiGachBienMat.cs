using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KhoiGachBienMat : MonoBehaviour
{
    GameObject Mario;
    private void Awake()
    {
        Mario = GameObject.FindGameObjectWithTag("Player");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.collider.tag == "Player"))
        {
            Destroy(gameObject);
        }
    }
}
