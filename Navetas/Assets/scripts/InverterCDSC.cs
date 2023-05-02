using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InverterCDSC : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponentInChildren<Animator>().SetBool("IsTouched", true);
        }
    }
    void Start()
    {
    }

    void Update()
    {

    }
}
