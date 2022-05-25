using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSC : MonoBehaviour
{
    private float TimeRemaining = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
