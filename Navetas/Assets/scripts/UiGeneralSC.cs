using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UiGeneralSC : MonoBehaviour
{
    private static GameObject instance;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = gameObject;
            GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}