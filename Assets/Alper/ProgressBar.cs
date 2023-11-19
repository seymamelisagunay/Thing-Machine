using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider timerSlider;
    public float countdownTime = 60f;
    public UIManager _uiIManager;


    private bool _stopTimer;
    private void Start()
    {
        StartTimer();
    }

    private void Update()
    {
        if (!_stopTimer)
        {
            countdownTime -= Time.deltaTime;
            timerSlider.value = countdownTime / 60f;
            
            if (countdownTime <= 0f)
            {
                _stopTimer = true;
                _uiIManager.FinishLevel();
            }
        }
        
    }

    private void StartTimer()
    {
        // Timer'i baslatmak icin cagirilir
        countdownTime = 15f;
        timerSlider.value = 1f; // Slider'i tamamen doldur
    }

}
