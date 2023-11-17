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
        // Timer'i baslat
        StartTimer();
    }

    private void Update()
    {
        // Timeri guncelle
        countdownTime -= Time.deltaTime;
        timerSlider.value = countdownTime / 60f;

        // Sayaci tamamlandi mi kontrol et
        if (countdownTime <= 0f)
        {
            Debug.Log("Sure BiTTi");
            // islem tamamlandiginda ek islemleri buraya ekleyebilirsiniz.
        }
    }

    private void StartTimer()
    {
        // Timer'i baslatmak icin cagirilir
        countdownTime = 60f;
        timerSlider.value = 1f; // Slider'i tamamen doldur
    }

}
