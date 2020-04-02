﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeSelection : MonoBehaviour
{

    public Toggle easy;
    public Toggle intermediate;
    public Toggle hard;
    


    public void logToggle()
    {
        activeToggle();
    }
    public void activeToggle()
    {
        if (easy.isOn)
        {
            Debug.Log("easy");
            TimerUI.countdownStartValue = 600;
        }
        else if (intermediate.isOn)
        {
            Debug.Log("intermediate");
            TimerUI.countdownStartValue = 300;
        }
        else if (hard.isOn)
        {
            Debug.Log("hard");
            TimerUI.countdownStartValue = 150;
        }
    }
   
   
}
