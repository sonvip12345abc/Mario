using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KhoiTangHinh : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Mario;

    private void Awake()
    {
        Mario = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "VaCham" && col.contacts[0].normal.y > 0)
        {
            GameObject KhoiGach = (GameObject)Instantiate(Resources.Load("Prefabs/KhoiGachDo"));
        }
    }
}
