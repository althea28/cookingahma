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

    private static int stepStart = 0;
    private static int stepMovedToast = 1;
    private static int stepAddKaya = 2;
    private static int stepAddButter = 3;
    private static int stepServeToast = 4;

    private void Start()
    {
        //=====
        Instantiate(steamObj, transform.position, steamObj.rotation);
        clickCount = stepStart;
        cookedTime = stepStart;

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
        if (clickCount == stepStart) //moving from grill to board
        {
            /*if (isPrevDisplayed)
            {

                HidePrevText();
                isPrevDisplayed = false;
            }*/

        }
        if (((clickCount == stepStart) && (innerToastTutorial.aHasChanged == "y") && (tutorialflow.addedToastB == "y")) ||
            ((clickCount == stepMovedToast) && (tutorialflow.kayaClicked == "y")) ||
            ((clickCount == stepAddKaya) && (tutorialflow.butterClicked == "y")) ||
            ((clickCount == stepAddButter) && (tutorialflow.addedButter == "y")))
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
        if (clickCount == stepMovedToast) //moved from grill to board, shows kaya text
        {
            //Debug.Log("fb1 shown");
            prevText.SetActive(false);
            feedbackText1.SetActive(true);

            //=====
            tutorialflow.destroySteamA = "y";
            tutorialflow.moveToGrill = "y";
            transform.position = tutorialflow.boardACoordinates;

        }
        else if (clickCount == stepAddKaya) //added kaya, shows butter text
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
        else if (clickCount == stepAddButter) //add butter, shows serve text
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

        else if (clickCount == stepServeToast) //abt to serve toast
        {
            feedbackText3.SetActive(false);
            serveCustomer.SetActive(true);

            //===
            tutorialflow.toastToServe = "y";
        }
    }


    private void HideFeedbackText1()
    {
        //Debug.Log("hiding fb1");
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
