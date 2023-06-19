using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timerslider : MonoBehaviour
{
    public Slider timerSlider;
    private TextMeshProUGUI timerText;
    public float gameTime;
    private bool stopTimer;
    public GameObject timerTextObject; 
    private Image sliderFillImage; 
    private Color startColor = Color.green;  
    private Color endColor = Color.red; 

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
        float time = gameTime - Time.time;
        int mins = Mathf.FloorToInt(time / 60);
        int secs = Mathf.FloorToInt(time - mins * 60f);
        string textTime = string.Format("{0:0}:{1:00}", mins, secs);
        
        if (time <= 0)
        {
            stopTimer = true;

            if (gameflow.customersServed >= 5)
            {
                // Transition to success scene, player has served 5/5 or more.
                SceneManager.LoadScene(3);
            }
            else
            {
                // Transition to game over scene
                SceneManager.LoadScene(4);
            }
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

    public void RestartTimer()
    {
        stopTimer = false;
        timerSlider.value = gameTime;
        timerText.text = string.Format("{0:0}:{1:00}", Mathf.FloorToInt(gameTime / 60), Mathf.FloorToInt(gameTime % 60));
    }
}