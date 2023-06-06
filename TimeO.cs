using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimeO : MonoBehaviour
{
  public static int countDownStartValue = 240;
    public TMP_Text TimerUI;


    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }
    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTimer = TimeSpan.FromSeconds(countDownStartValue);
            TimerUI.text = spanTimer.Minutes + " : " + spanTimer.Seconds;

            countDownStartValue--;
            Invoke("countDownTimer", 1f);
        }
    }
}
