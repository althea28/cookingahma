using UnityEngine;
using UnityEngine.UI;

public class buttertutorial : MonoBehaviour
{
    public GameObject prevText;
    public GameObject feedbackText;
    private bool isPrevDisplayed = true;
    private bool isClicked = false;

    private void Start()
    {
        isPrevDisplayed = true;
        isClicked =false;

    }

    private void Update() 
    {
        

     
    }

    private void OnMouseDown()
    {
        //=====
        if ((!isClicked) && (tutorialflow.moveToGrill == "y") && 
            (tutorialflow.addedKaya == "y") && (tutorialflow.addedButter == "n"))
        {
            if (isPrevDisplayed)
            {
                HidePrevText();
                isPrevDisplayed = false;
            }
            ClickIngredient();
            isClicked = true;
        }
    }

    private void HidePrevText()
    {
        prevText.SetActive(false);
    }

    private void ClickIngredient()
    {
        //Debug.Log("Ingredient clicked!");
        feedbackText.SetActive(true);

        //====
        tutorialflow.butterClicked = "y";

    }

    private void HideFeedbackText()
    {
        feedbackText.SetActive(false);
    }
}

