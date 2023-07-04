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

   public void TutorialSelection ()
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

   public void ToastTutorial ()
   {
    SceneManager.LoadScene(3);
   }

   public void EggsTutorial ()
  {
    SceneManager.LoadScene(4);
  }

  public void CkTutorial ()
  {
    SceneManager.LoadScene(8);
  }

}
