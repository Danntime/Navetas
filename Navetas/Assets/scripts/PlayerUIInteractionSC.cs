using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerUIInteractionSC : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public void OnToggleTimer(InputAction.CallbackContext context)
    {
        Debug.Log("bibibi");
        if (context.performed)
        {
            Debug.Log("bababa");
            textDisplay.enabled = !textDisplay.enabled;
        }
    }
    private void Start()
    {
        textDisplay.enabled = false;
}
