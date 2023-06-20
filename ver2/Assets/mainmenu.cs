using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   public void PlayGame ()
   {
     SceneManager.LoadScene(1);
   }

   public void TutorialMode ()
   {
     SceneManager.LoadScene(2);
   }

   public void QuitGame () 
   {
     Application.Quit();
   }
   
   public void TryAgain () 
   { 
    SceneManager.LoadScene(1);
   }

}
