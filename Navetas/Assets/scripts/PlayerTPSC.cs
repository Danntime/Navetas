using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerTPSC : MonoBehaviour
{
    private GameObject currentTeleporter;
    void Start()
    {
       
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
      public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<teleporterSC>().GetDestination().position;
            }
        }
    }
}
