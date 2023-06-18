using UnityEngine;
using UnityEngine.UI;

public class kayatutorial : MonoBehaviour
{
    public GameObject prevText;
    public GameObject feedbackText;
    private bool isPrevDisplayed = true;
    private bool isClicked = false;

    private void Start()
    {

    }

    private void OnMouseDown()
    {
        if (!isClicked)
        {
            if (isPrevDisplayed)
            {
                HidePrevText();
                Debug.Log("Prev text hidden!");

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
        Debug.Log("Ingredient clicked!");

        feedbackText.SetActive(true);

    }

    private void HideFeedbackText()
    {
        feedbackText.SetActive(false);
    }
}

