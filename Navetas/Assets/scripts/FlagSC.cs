using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagSC : MonoBehaviour
{
    public string niveauSuivant;
    public GameObject timer;
    // Passer au niveau suivant
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            Debug.Log("boup");
            SceneManager.LoadScene(niveauSuivant, LoadSceneMode.Single);
        }
    }
}
