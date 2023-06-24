using UnityEngine;

public class toastloaftutorial : MonoBehaviour
{
    public GameObject instructionText;
    public GameObject feedbackText1;
    public GameObject feedbackText2;
    private bool isInstructionDisplayed = true;
    private int clickCount = 0;

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

        if (clickCount == 1)
        {
            feedbackText1.SetActive(true);

        }
        else if (clickCount == 2)
        {          
            HideFeedbackText1();
            feedbackText2.SetActive(true);
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
