using UnityEngine;

public class appear : MonoBehaviour
{
    public float appearanceTime = 5f; // Time at which the prefab should appear, in seconds

    private float timer = 0f; // Timer to track the elapsed time
    private bool hasAppeared = false; // Flag to indicate if the prefab has appeared

    private void Start()
    {
        gameObject.SetActive(false); // Deactivate the prefab initially
    }

    private void Update()
    {
        if (!hasAppeared)
        {
            timer += Time.deltaTime;

            // Check if the elapsed time matches the appearance time
            if (timer >= appearanceTime)
            {
                gameObject.SetActive(true); // Enable the prefab to make it appear
                hasAppeared = true; // Set the flag to indicate that the prefab has appeared
            }
        }
    }
}

