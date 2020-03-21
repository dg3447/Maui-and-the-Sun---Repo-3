using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class TimerUI : MonoBehaviour
{
    int countdownStartValue = 5;
    public Text timerUI;
    [SerializeField]
    


    // Start is called before the first frame update
    void Start()
    {
        countdownTimer();
       
    }

    public void countdownTimer()
    {
        if (countdownStartValue>0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countdownStartValue);
            timerUI.text = spanTime.Minutes + ":" + spanTime.Seconds;
            countdownStartValue--;
            Invoke("countdownTimer", 1.0f);
        }
        else
        {

            timerUI.text = "Time up!";
            endgame();
           // SceneManager.LoadScene(0);
           
        }
    }

    private void endgame()
    {
       // gameOverUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
