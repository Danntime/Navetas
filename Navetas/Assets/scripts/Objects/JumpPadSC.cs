using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadSC : MonoBehaviour
{
    private readonly float bounce = 10f;
    public Vector2 direction;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(direction* bounce, ForceMode2D.Impulse);

        }
    }
}
