using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetweenScenes : MonoBehaviour
{
    List<string> scenesToPause = new List<string>
    {
        "LEVEL1", "LEVEL2", "LEVEL3", "LEVEL4", "LEVEL5", "LEVEL6", "LEVEL7", "LEVEL8", "LEVEL9",
        "Success",
        "GameOver", 
        "FinalScene"

    };

    bool isMusicPaused = false; // Track whether the music is paused or not

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        string currentScene = SceneManager.GetActiveScene().name;

        if (scenesToPause.Contains(currentScene))
        {
            if (!isMusicPaused)
            {
                BGM.instance.GetComponent<AudioSource>().Pause();
                isMusicPaused = true;
            }
        }
        else
        {
            if (isMusicPaused)
            {
                BGM.instance.GetComponent<AudioSource>().UnPause();
                isMusicPaused = false;
            }
        }
    }
}