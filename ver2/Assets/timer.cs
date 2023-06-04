using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public Text timerText;

    private void Start()
    {
        
        UpdateTimerText();
    }

    private void Update()
    {
        // Update the timer and check if time has run out
        if (timeRemaining > 0f)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
 
            HandleTimeUp();
        }
    }

    private void UpdateTimerText()
    {
        // Update the timer text to display the time remaining
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        string timeText = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timeText;
    }

    private void HandleTimeUp()
    {
 
        Debug.Log("Time's up!");
    }
}
