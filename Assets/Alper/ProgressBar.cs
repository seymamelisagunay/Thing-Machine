using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider timerSlider;
    public float countdownTime = 60f;

    private void Start()
    {
        // Timer'� ba�lat
        StartTimer();
    }

    private void Update()
    {
        // Timer'� g�ncelle
        countdownTime -= Time.deltaTime;
        timerSlider.value = countdownTime / 60f;

        // Saya� tamamland� m� kontrol et
        if (countdownTime <= 0f)
        {
            Debug.Log("S�re B�TT�");
            // ��lem tamamland���nda ek i�lemleri buraya ekleyebilirsiniz.
        }
    }

    private void StartTimer()
    {
        // Timer'� ba�latmak i�in �a�r�l�r
        countdownTime = 60f;
        timerSlider.value = 1f; // Slider'� tamamen doldur
    }

}
