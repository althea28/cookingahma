using UnityEngine;
using UnityEngine.UI;

public class toasttutorial : MonoBehaviour
{
    public GameObject prevText;
    public GameObject feedbackText1;
    public GameObject feedbackText2;
    public GameObject feedbackText3;
    public GameObject kayaText;
    public GameObject butterText;
    public GameObject serveCustomer;
    private bool isPrevDisplayed = true;
    private int clickCount = 0;

    private void Start()
    {

    }

    private void OnMouseDown()
    {
        if (clickCount==0)
        {
            if (isPrevDisplayed)
            {

                HidePrevText();
                isPrevDisplayed = false;
            }

        }
        clickCount++;
        ClickIngredient();
    }

    private void HidePrevText()
    {
        prevText.SetActive(false);
    }

    private void ClickIngredient()
    {
        if (clickCount == 1)
        {
            Debug.Log("fb1 shown");
            feedbackText1.SetActive(true); 

        }
        else if (clickCount == 2)
        {        
            Debug.Log("2nd click!");
            HideKayaText();
            feedbackText2.SetActive(true);

        }
        else if (clickCount == 3)
        {        
            Debug.Log("3rd click!");
            HideButterText();
            feedbackText3.SetActive(true);

        }

        else if (clickCount == 4)
        {
            feedbackText3.SetActive(false);
            serveCustomer.SetActive(true);
        }
    }


    private void HideFeedbackText1()
    {
        feedbackText1.SetActive(false);
    }

    private void HideKayaText()
    {
        kayaText.SetActive(false);
    }

    private void HideButterText()
    {
        butterText.SetActive(false);
    }
}
