using UnityEngine;
using UnityEngine.UI;

public class customertutorial : MonoBehaviour
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
                isPrevDisplayed = false;
            }
            ClickCustomer();
            isClicked = true;
        }
    }

    private void HidePrevText()
    {
        prevText.SetActive(false);
    }

    private void ClickCustomer()
    {
        //Debug.Log("Customer clicked!");
        feedbackText.SetActive(true);

    }

    private void HideFeedbackText()
    {
        feedbackText.SetActive(false);
    }
}
