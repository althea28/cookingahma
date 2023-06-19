using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerslider : MonoBehaviour
{
    public Slider timerSlider;
    private TextMeshProUGUI timerText;
    public float gameTime;
    private float elapsedTime;
    private bool stopTimer;
    public GameObject timerTextObject; 
    private Image sliderFillImage; 
    private Color startColor = Color.green;  
    private Color endColor = Color.red; //  


    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        timerText = timerTextObject.GetComponent<TextMeshProUGUI>();

        sliderFillImage = timerSlider.fillRect.GetComponent<Image>(); 
        sliderFillImage.color = startColor; 

        elapsedTime = 0f;
    }
    void Update()
    {
        elapsedTime += Time.deltaTime; 
        float time = gameTime - elapsedTime;
        int mins = Mathf.FloorToInt(time / 60);
        int secs = Mathf.FloorToInt(time - mins * 60f);
        string textTime = string.Format("{0:0}:{1:00}", mins, secs);
<<<<<<< Updated upstream
        if (time <= 0)
=======

        if (gameflow.count > 0 && time <= 0)
>>>>>>> Stashed changes
        {
            Debug.Log("Here");
            ResetTimer();
        }
        else if (time <= 0 && gameflow.count == 0)
        {
            gameflow.count++;
            stopTimer = true;
        }
        if (!stopTimer)
        {
            timerText.text = textTime;
            timerSlider.value = time;

            // Calculate the current color based on the time remaining
            float t = Mathf.InverseLerp(0, gameTime, time);
            sliderFillImage.color = Color.Lerp(endColor, startColor, t);
        }
    }
<<<<<<< Updated upstream
=======

    void ResetTimer()
    {
        stopTimer = false;
        timerSlider.value = gameTime;
        float time = gameTime;
        int mins = Mathf.FloorToInt(time / 60);
        int secs = Mathf.FloorToInt(time - mins * 60f);
        string textTime = string.Format("{0:0}:{1:00}", mins, secs);
        timerText.text = textTime;
    }
>>>>>>> Stashed changes
}