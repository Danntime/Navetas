using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFlag : MonoBehaviour
{
    Vector3 initPos;
    private void Start()
    {
        initPos = transform.parent.position;
    }
    private void OnTriggerEnter2D(Collider2D collision) // Déplace le flag si le joueur entre dans la zone de collision
    {
        Debug.Log("Est entré");
        if (collision.gameObject.CompareTag("Player"))
        {
            while (transform.parent.position.x <= 31)
            {
                transform.parent.position += new Vector3(0.000001f, 0, 0);
            }
        }
    }
}
