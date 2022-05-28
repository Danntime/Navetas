using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class TimerSC : MonoBehaviour
{
    public float timerCount = 0;
    private int timerCountInteger;
    private TextMeshProUGUI timer;
    private void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        timerCountInteger = (int)timerCount;
        timerCount += Time.deltaTime;
        timer.text = timerCountInteger.ToString();
    }

}