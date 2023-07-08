using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{


    public void TryClicked()
    {
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

    }
}