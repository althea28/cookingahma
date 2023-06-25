using UnityEngine;
using UnityEngine.UI;

public class customertutorial : MonoBehaviour
{
    public GameObject prevText;
    public GameObject feedbackText;
    private bool isPrevDisplayed = true;
    private bool isClicked = false;

    public Transform reqObj;

    private void Start()
    {
        Instantiate(reqObj, transform.position+tutorialflow.addReqCoordinates, reqObj.rotation);
        isPrevDisplayed = true;
        isClicked = false;

    }

    private void OnMouseDown()
    {
        if ((!isClicked) && (tutorialflow.toastToServe == "y"))
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

        //=====
        tutorialflow.toastToServe = "n";
        tutorialflow.destroyKaya = "y";
        tutorialflow.destroyButter = "y";
        tutorialflow.destroyToast = "y";
        tutorialflow.destroyReq = "y";
        Destroy(gameObject);



    }

    private void HideFeedbackText()
    {
        feedbackText.SetActive(false);
    }
}
