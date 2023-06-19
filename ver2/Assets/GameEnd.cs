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
      SceneManager.LoadScene(1); //need to change to the number of the next lvl scene
    }
}