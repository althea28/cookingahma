using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{

    public AudioSource soundPlayer;

    public void TryClicked()
    {
        soundPlayer.Play();
        DontDestroyOnLoad(soundPlayer.gameObject);
        
        if (gameflow.sceneCounter == 0) 
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(1);
        }
        else if (gameflow.sceneCounter == 1)
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(7);
        }
        else if (gameflow.sceneCounter == 2)
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(9);
        }
        else if (gameflow.sceneCounter == 3)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(12);
        }
        else if (gameflow.sceneCounter == 4)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(15);
        }
        
    }


    public void NextLevel()
    {

        if (gameflow.sceneCounter == 1)
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(7); // level 1 to level 2
 
        }
        else if (gameflow.sceneCounter == 2)
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(9); // level 2 to level 3
            
        }
        
        else if (gameflow.sceneCounter == 3)
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(11); // level 3 to snack stall intro
            
        } 

        else if (gameflow.sceneCounter == 4)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(13); // level 4 to level 5
        }

        else if (gameflow.sceneCounter == 5)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(15); // level 4 to level 5
        }
    }
}