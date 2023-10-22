using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class MovingFlag : MonoBehaviour
{
    [SerializeField] private Vector2 targetVelocity;
    [SerializeField] private Vector2 targetPosition1;
    [SerializeField] private Vector2 targetPosition2;
    [SerializeField] private Vector2 targetPosition3;
    private int compteur = 0;
   
    [SerializeField] private float approximation = 0.2f;
    // variable pour ajouter une approximation a la position finale de l'objet.

    private void OnTriggerEnter2D(Collider2D collision) 
    // Deplace le flag en augmentant sa velocite si le joueur entre dans la zone de collision
    {
        if (collision.gameObject.CompareTag("Player"))
        {
                GetComponentInParent<Rigidbody2D>().velocity = new Vector2(targetVelocity.x, targetVelocity.y);
                             compteur++;
        }
    }
    private void Update()
    // annule sa vélocité quand l'objet a atteint son point de destination, CaD que (position =(targetX;targetY))
    { 
        print(compteur);
        switch (compteur)
        {
            case 1:
                if (Vector3.Distance(transform.parent.position, new Vector3(targetPosition1.x,targetPosition1.y)) <= approximation)
                {
                    GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
                }
                break;
            case 2:
                if (Vector3.Distance(transform.parent.position, new Vector3(targetPosition2.x,targetPosition2.y)) <= approximation)
                {
                    GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
                }
                break;
                case 3:
                if (Vector3.Distance(transform.parent.position, new Vector3(targetPosition3.x,targetPosition3.y)) <= approximation)
                {
                    GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
                }
                break;
        }
    }
}
