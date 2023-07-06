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
    //private bool isPrevDisplayed = true;
    private int clickCount = 0;

    public Transform steamObj;
    public Transform kayaSpreadObj;
    public Transform butterSpreadObj;
    private static float cookedTime = 0;

    private void Start()
    {
        //=====
        Instantiate(steamObj, transform.position, steamObj.rotation);
        clickCount = 0;
        cookedTime = 0;

    }

    private void Update()
    {
        if ((cookedTime < tutorialflow.timeToCook) && (transform.position == tutorialflow.grillACoordinates))
        {
            cookedTime += Time.deltaTime;
        }
        if (cookedTime >= tutorialflow.timeToCook) 
        {
            tutorialflow.changeInnerA = "y";
        }


        if ((tutorialflow.destroyToast == "y") && (transform.position == tutorialflow.boardACoordinates)) {
            Destroy (gameObject);
            tutorialflow.destroyToast = "n";
        }
    }

    private void OnMouseDown()
    {
        //Debug.Log("cc: "+clickCount);
        if (clickCount==0) //moving from grill to board
        {
            /*if (isPrevDisplayed)
            {

                HidePrevText();
                isPrevDisplayed = false;
            }*/

        }
        if (((clickCount == 0) && (innerToastTutorial.aHasChanged == "y") && (tutorialflow.addedToastB == "y")) ||
            ((clickCount == 1) && (tutorialflow.kayaClicked == "y")) ||
            ((clickCount == 2) && (tutorialflow.butterClicked == "y")) ||
            ((clickCount == 3) && (tutorialflow.addedButter == "y")))
        {
            clickCount++;
            ClickIngredient();
        }
        //Debug.Log("ccafter: "+clickCount);
    }

    private void HidePrevText()
    {
        prevText.SetActive(false);
    }

    private void ClickIngredient()
    {
        if (clickCount == 1) //moved from grill to board, shows kaya text
        {
            //Debug.Log("fb1 shown");
            prevText.SetActive(false);
            feedbackText1.SetActive(true);

            //=====
            tutorialflow.destroySteamA = "y";
            tutorialflow.moveToGrill = "y";
            transform.position = tutorialflow.boardACoordinates;

        }
        else if (clickCount == 2) //added kaya, shows butter text
        {        
            //Debug.Log("2nd click!");
            HideKayaText();
            feedbackText2.SetActive(true);
            kayaspoontutorial.moveDown = true;
            
            //===
            Instantiate(kayaSpreadObj, transform.position+tutorialflow.addKayaCoordinates, kayaSpreadObj.rotation);
            tutorialflow.kayaClicked = "n";
            tutorialflow.addedKaya = "y";

        }
        else if (clickCount == 3) //add butter, shows serve text
        {        
            //Debug.Log("3rd click!");
            HideButterText();
            feedbackText3.SetActive(true);
            butterknifetutorial.moveDown = true;
            
            //=====
            Instantiate(butterSpreadObj, transform.position+tutorialflow.addButterCoordinates, butterSpreadObj.rotation);
            tutorialflow.butterClicked = "n";
            tutorialflow.addedButter = "y";


        }

        else if (clickCount == 4) //abt to serve toast
        {
            feedbackText3.SetActive(false);
            serveCustomer.SetActive(true);

            //===
            tutorialflow.toastToServe = "y";
        }
    }


    private void HideFeedbackText1()
    {
        Debug.Log("hiding fb1");
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
