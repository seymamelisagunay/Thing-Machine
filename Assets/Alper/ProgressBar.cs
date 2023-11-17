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
        // Timer'ý baþlat
        StartTimer();
    }

    private void Update()
    {
        // Timer'ý güncelle
        countdownTime -= Time.deltaTime;
        timerSlider.value = countdownTime / 60f;

        // Sayaç tamamlandý mý kontrol et
        if (countdownTime <= 0f)
        {
            Debug.Log("Süre BÝTTÝ");
            // Ýþlem tamamlandýðýnda ek iþlemleri buraya ekleyebilirsiniz.
        }
    }

    private void StartTimer()
    {
        // Timer'ý baþlatmak için çaðrýlýr
        countdownTime = 60f;
        timerSlider.value = 1f; // Slider'ý tamamen doldur
    }

}
