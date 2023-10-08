using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class TimerSC : MonoBehaviour
{
    public float timerCount = 0;
    private TextMeshProUGUI timer;
    private void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        timerCount += Time.deltaTime;
        timer.text = (Mathf.Round(timerCount * 100.0f) / 100.0f, 2).ToString();
    }

}