using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class MovingFlag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // D�place le flag si le joueur entre dans la zone de collision
    {
        Debug.Log("Est entr�");
        if (collision.gameObject.CompareTag("Player"))
        {
                GetComponentInParent<Rigidbody2D>().velocity = new Vector2(4, 0);
        }
    }
    private void FixedUpdate()
    {
        if (transform.parent.position.x <= 31)
        {
            GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
