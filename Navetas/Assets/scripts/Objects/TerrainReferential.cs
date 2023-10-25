using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainReferential : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            playerRb.interpolation = RigidbodyInterpolation2D.None;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
            Rigidbody2D playerRb = collision.gameObject.GetComponent<Rigidbody2D>();

            playerRb.interpolation = RigidbodyInterpolation2D.Interpolate;
        }
    }
}
