using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{


    public void TryClicked()
    {

        Debug.Log("Clicked");
        SceneManager.LoadScene(1);
        
    }


    public void NextLevel()
    {

        if (gameflow.sceneCounter == 0)
        {
            SceneManager.LoadScene(7); // level 1 to level 2
            gameflow.sceneCounter++;
        }
        else if (gameflow.sceneCounter == 1)
        {
            SceneManager.LoadScene(1); // level 2 to level 3, put placeholder 1 for level 3 first.
            gameflow.sceneCounter++;
        }

    }
}