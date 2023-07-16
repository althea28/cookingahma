using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
    private Color endColor = Color.red; 

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
    

        if (gameflow.count > 0 && time <= 0)

        {
            Debug.Log("Here");
            ResetTimer();
        }
        else if (time <= 0) //&& gameflow.count == 0)
        {
                
            stopTimer = true;

            if ((gameflow.customersServed >= 1 && gameflow.sceneCounter == 0) ||
                (gameflow.customersServed >= 1 && gameflow.sceneCounter == 1) ||
                (gameflow.customersServed >= 1 && gameflow.sceneCounter == 2) ||
                (gameflow2.customersServed >= 1 && gameflow.sceneCounter == 3) ||
                (gameflow2.customersServed >= 1 && gameflow.sceneCounter == 4) ||
                (gameflow2.customersServed >= 1 && gameflow.sceneCounter == 5))
            {
                // Transition to success scene, player has attained level goal
                gameflow.sceneCounter++;
                SceneManager.LoadScene(5);
            }
            else if ((gameflow.customersServed < 1 && gameflow.sceneCounter == 0) ||
                (gameflow.customersServed < 1 && gameflow.sceneCounter == 1) ||
                (gameflow.customersServed < 1 && gameflow.sceneCounter == 2) ||
                (gameflow2.customersServed < 1 && gameflow.sceneCounter == 3) ||
                (gameflow2.customersServed < 1 && gameflow.sceneCounter == 4) ||
                (gameflow2.customersServed < 1 && gameflow.sceneCounter == 5))
            {
                // Transition to game over scene
                SceneManager.LoadScene(6);
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

    public void RestartTimer()
    {
        stopTimer = false;
        timerSlider.value = gameTime;
        timerText.text = string.Format("{0:0}:{1:00}", Mathf.FloorToInt(gameTime / 60), Mathf.FloorToInt(gameTime % 60));
    }

}