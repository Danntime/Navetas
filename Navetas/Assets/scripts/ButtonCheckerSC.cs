using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheckerSC : MonoBehaviour
{
    public bool isChecked;
    public Sprite clickedButton;
    public GameObject currentButton;
    // Activation sur collision verticale
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponentInParent<SpriteRenderer>().sprite = clickedButton;
            Object.Destroy(currentButton);
            isChecked = true;
        }
    }
}
