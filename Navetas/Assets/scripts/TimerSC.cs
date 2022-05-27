using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerSC : MonoBehaviour
{
  public TextMeshProUGUI textDisplay;
  public float TimeRemaining = 50f;
  private int TimeInteger;


  void Update()
  {
    TimeInteger = (int)TimeRemaining;
      textDisplay.text =  TimeInteger.ToString();
  }
    void FixedUpdate()
    {
        if (TimeRemaining > 0)
        {
            TimeRemaining -= Time.fixedDeltaTime;
        }
        else
        {
            //timerTrigger
        }
    }
}
