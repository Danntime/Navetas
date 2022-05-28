using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerUISC : MonoBehaviour
{
    private TextMeshProUGUI timer;


    void Start()
    {
        timer = GameObject.Find("Chrono").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }
    public void OnToggleTimer(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            timer.enabled = !timer.enabled;
        }
    }
}
