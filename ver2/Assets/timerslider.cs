using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerslider : MonoBehaviour
{
    public Slider timerSlider;
    public GameObject timerTextObject;
    public float gameTime;
    private bool stopTimer;
    private bool gameBegin = false;
    private TextMeshProUGUI timerText;
    private Image sliderFillImage; 
    private Color endColor = Color.green;  
    private Color startColor = Color.red;

    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        timerText = timerTextObject.GetComponent<TextMeshProUGUI>();
        sliderFillImage = timerSlider.fillRect.GetComponent<Image>();  
        sliderFillImage.color = startColor;
    }

    void Update()
    {
        if (gameBegin)
        {
            float time = gameTime - Time.time;
            int mins = Mathf.FloorToInt(time / 60);
            int secs = Mathf.FloorToInt(time - mins * 60f);
            string textTime = string.Format("{0:0}:{1:00}", mins, secs);
            if (time <= 0)
            {
                stopTimer = true;
            }
            if (!stopTimer)
            {
                timerText.text = textTime;
                timerSlider.value = time;

                // Calculate current colour based on time remaining
                float t = Mathf.InverseLerp(0, gameTime, time);
                sliderFillImage.color = Color.Lerp(startColor, endColor, t); 
            }
        }
    }

    void OnEnable()
    {
        gameBegin = true;
        gameTime = 60f; // Reset duration to 60 seconds
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        sliderFillImage.color = startColor;
    }
}

