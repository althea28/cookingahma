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
            SceneManager.LoadScene(1); //retry level 1
        }
        else if (gameflow.sceneCounter == 1)
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(7); //retry level 2
        }
        else if (gameflow.sceneCounter == 2)
        {
            gameflow.customersServed = 0;
            SceneManager.LoadScene(9); //retry level 3
        }
        else if (gameflow.sceneCounter == 3)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(12); //retry level 4
        }
        else if (gameflow.sceneCounter == 4)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(13); //retry level 5
        }

        else if (gameflow.sceneCounter == 5)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(15); //retry level 6
        }

        else if (gameflow.sceneCounter == 6)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(18); //retry level 7
        }
        else if (gameflow.sceneCounter == 7)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(19); //retry level 8
        }
        else if (gameflow.sceneCounter == 8)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(20); //retry level 9
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
            SceneManager.LoadScene(15); // level 5 to level 6
        }
        
        else if (gameflow.sceneCounter == 6)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(17); // level 6 to dessert stall intro
        }

        else if (gameflow.sceneCounter == 7)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(19); // level 7 to level 8
        }

        else if (gameflow.sceneCounter == 8)
        {
            gameflow2.customersServed = 0;
            SceneManager.LoadScene(20); // level 8 to level 9
        }
    }
}