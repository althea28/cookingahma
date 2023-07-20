using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

   public void Back ()
   {
    SceneManager.LoadScene(0);
   }


   public void PlayGame ()
   {
    SceneManager.LoadScene(10);
   }

   public void PlayToast ()
   {
     SceneManager.LoadScene(1);
   }

   public void PlayCKRojak ()
   {
     SceneManager.LoadScene(12);
   }

   public void PlayDessert ()
   {
    SceneManager.LoadScene(18);
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
  
  public void RojakTutorial ()
  {
    SceneManager.LoadScene(14);
  }

  public void OndehTutorial ()
  {
    SceneManager.LoadScene(16);
  }
}
