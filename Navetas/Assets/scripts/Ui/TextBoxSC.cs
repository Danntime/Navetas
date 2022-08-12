using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextBoxSC : MonoBehaviour
{
    private TextMeshProUGUI textBox;
    [HideInInspector] public string text;
    void Start()
    {
        textBox = GetComponentInChildren<TextMeshProUGUI>();
        textBox.text = text;
    }

    void Update()
    {
        textBox = GetComponentInChildren<TextMeshProUGUI>();  
        textBox.text = text;
    }
}
