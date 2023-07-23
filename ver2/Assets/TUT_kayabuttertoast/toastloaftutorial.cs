using UnityEngine;

public class toastloaftutorial : MonoBehaviour
{
    public GameObject instructionText;
    public GameObject feedbackText1;
    public GameObject feedbackText2;
    private bool isInstructionDisplayed = true;
    private int clickCount = 0;
    
    //=====
    public Transform toastAObj;
    public Transform toastBObj;

    private static int stepAddToastA = 1;
    private static int stepAddToastB = 2;



    private void Start()
    {
        instructionText.SetActive(true);
    }

   

    private void OnMouseDown()
    {
        if (isInstructionDisplayed)
        {
            HideInstructionText();
            isInstructionDisplayed = false;

        }

        clickCount++;
        ClickIngredient();
    }

    private void HideInstructionText()
    {
        instructionText.SetActive(false);
    }

    private void ClickIngredient()
    {
        //Debug.Log("Ingredient collected!");

        if (clickCount == stepAddToastA)
        {
            feedbackText1.SetActive(true);
            //====
            Instantiate(toastAObj, tutorialflow.grillACoordinates, toastAObj.rotation);

        }
        else if (clickCount == stepAddToastB)
        {          
            HideFeedbackText1();
            feedbackText2.SetActive(true);
            //====
            Instantiate(toastBObj, tutorialflow.grillBCoordinates, toastBObj.rotation);
            tutorialflow.addedToastB = "y";

        }
    }

    private void HideFeedbackText1()
    {
        feedbackText1.SetActive(false);
    }

    private void HideFeedbackText2()
    {
        feedbackText2.SetActive(false);
    }
}
