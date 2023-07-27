using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* Attached to all toast objects. Supports:
 * (i) Serving a correctly prepared kaya butter toast dish
 * (ii) Addition of kaya and butter to toast
 * (iii) Cooking and burning of toast when it is on the grill
*/

public class toastclick : MonoBehaviour
{

    public Transform kayaObj;
    public Transform butterObj;
    public Transform steamObj;

    public static bool hasKayaOnA = false;
    public static bool hasKayaOnB = false;
    public static bool hasButterOnA = false;
    public static bool hasButterOnB = false;

    public static float cookingTimeA = 0;
    public static float cookingTimeB = 0;
    public static bool toastAIsCooked = false;
    public static bool toastBIsCooked = false;
    public static bool toastAIsBurnt = false;
    public static bool toastBIsBurnt = false;
    private float timeForToastToCook = 3f;
    private float timeForToastToBurn = 5f; //shld b 10 but change to 5 for faster debugging

    //toastAIsCooked is for material change. toastOnBoardAIsCooked is for when checking if dish is correct
    public static bool toastOnBoardAIsCooked = false;     
    public static bool toastOnBoardBIsCooked = false;
    public static bool isToastAReady = false;
    public static bool isToastBReady = false;

    public static bool serveToastA = false;
    public static bool serveToastB = false;

    // Start is called before the first frame update
    void Start()
    /* Instantiates steam when toast is on grill
    */
    {
        Instantiate(steamObj, transform.position, steamObj.rotation);

    }

    // Update is called once per frame
    /* Supports several toast preparation functions: 
     * (i) Indicates if toast can be served to a customer.
     * (ii) Checks if toast needs to be destroyed.
     * (iii) Checks if toast has been cooked/burned and trigger visual change when it happens.
     * (iv) Triggers successful serve of toast.
    */
    void Update()
    {
        //check if toast can be served     
        if ((toastOnBoardAIsCooked) && (hasKayaOnA) && (hasButterOnA)) {
            isToastAReady = true;
        }
        if ((toastOnBoardBIsCooked) && (hasKayaOnB) && (hasButterOnB)) {
            isToastBReady = true;
        }

        //check to trash
        if ((gameflow.trashA) && (transform.position == gameflow.boardACoordinates)) {
            trashANow();
            gameflow.trashA = false;
        }
        if ((gameflow.trashB) && (transform.position == gameflow.boardBCoordinates)) {
            trashBNow();
            gameflow.trashB = false;
        }
                

        if (isOnGrillA()) {
            cookingTimeA += Time.deltaTime;
            
            checkCookingA();
            /*if (cookingTimeA > timeForToastToCook) { 
                toastAIsCooked = "y";
            }
            if (cookingTimeA > timeForToastToBurn) {
                toastAIsBurnt = "y";
            }*/
        } else if (isOnGrillB()) {
            cookingTimeB += Time.deltaTime;

            checkCookingB();
            /*if (cookingTimeB > timeForToastToCook) {
                toastBIsCooked = "y";
            }
            if (cookingTimeB > timeForToastToBurn) {
                toastBIsBurnt = "y";
            }*/
        }

        if (serveToastA) {
            serveA();
        } else if (serveToastB) {
            serveB();
        }

    }

    /* Supports several toast preparation functions:
     * (i) Indicate in gameflow when clicked, to assist trashing and serving
     * (ii) Adding kaya and butter condiments to the toast
     * (iii) Moving toast from grill to board
    */
    void OnMouseDown() {
        
        //in case of double click. needs to b at the top
        if ((gameflow.toastAIsClicked) || (gameflow.toastBIsClicked)) {
            gameflow.toastAIsClicked = false;
            gameflow.toastBIsClicked = false;
        }

        //clicking dish for serving or trashing
        if ((isOnBoard()) && (!gameflow.placeButter) && (!gameflow.placeKaya)) {

            clickingDish();

            /*if (isOnBoardA()) {
                gameflow.toastAIsClicked = "y";
                
                //RESET===
                gameflow.toastBIsClicked = "n";
            } else {
                gameflow.toastBIsClicked = "y";

                //RESET===
                gameflow.toastAIsClicked = "n";
            }*/

        } else if ((gameflow.placeKaya) && (isOnBoard())) { //placing kaya on board
            placeKaya();

            /*if ((isOnBoardA()) && (hasKayaOnA == "n")) {
                hasKayaOnA = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "n")) { 
                hasKayaOnB = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            }*/

            //RESET=== 
            gameflow.toastAIsClicked = false;
            gameflow.toastBIsClicked = false;

        } else if ((gameflow.placeButter)  && (isOnBoard())) { //placing butter on board

            placeButter();
            /*if ((isOnBoardA()) && (hasKayaOnA == "y") && (hasButterOnA == "n")) {
                hasButterOnA = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "y") && (hasButterOnB == "n")) {
                hasButterOnB = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            }*/

            //RESET=== 
            gameflow.toastAIsClicked = false;
            gameflow.toastBIsClicked = false;

        } else if ((isOnGrill()) && (!gameflow.toastOnBoardA)) { //moving from grill to boardA
            checkIfCookedWellA();
            resetAfterMoving();
            GetComponent<Transform> ().position = gameflow.boardACoordinates;
            gameflow.toastOnBoardA = true;

            //RESET=== 
            gameflow.resetClicksToast = true;

        } else if ((isOnGrill()) && (!gameflow.toastOnBoardB)) { //moving from grill to boardB
            checkIfCookedWellB();
            resetAfterMoving();
            GetComponent<Transform> ().position = gameflow.boardBCoordinates;
            gameflow.toastOnBoardB = true;

            
            //RESET=== 
            gameflow.resetClicksToast = true;

        }
        
        //RESET===
        gameflow.placeKaya = false;
        gameflow.placeButter = false;
        gameflow.resetClicksEggs = true;

    }

    /* Check if toast on position A of grill has been cooked or burnt
    */
    void checkCookingA() {
        if (cookingTimeA > timeForToastToCook) { 
            toastAIsCooked = true;
        }
        if (cookingTimeA > timeForToastToBurn) {
            toastAIsBurnt = true;
        }
    }

    /* Check if toast on position B of grill has been cooked or burnt
    */
    void checkCookingB() {
        if (cookingTimeB > timeForToastToCook) {
            toastBIsCooked = true;
        }
        if (cookingTimeB > timeForToastToBurn) {
            toastBIsBurnt = true;
        }
    }

    /* Indicate in gameflow when toast has been clicked. Supports trashing and serving mechanism.
    */
    void clickingDish() {
        if (isOnBoardA()) {
            gameflow.toastAIsClicked = true;

            //RESET===
            gameflow.toastBIsClicked = false;
        } else {
            gameflow.toastBIsClicked = true;

            //RESET===
            gameflow.toastAIsClicked = false;
        }
    }

    /* Add kaya condiment to toast.
    */
    void placeKaya() {
        if ((isOnBoardA()) && (!hasKayaOnA)) {
            hasKayaOnA = true;
            Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
        } else if ((isOnBoardB()) && (!hasKayaOnB)) { 
            hasKayaOnB = true;
            Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
        }
    }

    /* Add butter condiment to toast.
    */
    void placeButter() {
        if ((isOnBoardA()) && (hasKayaOnA) && (!hasButterOnA)) {
            hasButterOnA = true;
            Instantiate(butterObj, newButterPosition(), butterObj.rotation);
        } else if ((isOnBoardB()) && (hasKayaOnB) && (!hasButterOnB)) {
            hasButterOnB = true;
            Instantiate(butterObj, newButterPosition(), butterObj.rotation);
        }
    }

    /* Destroy toast object on position A of board during serving and trashing mechanisms.
    */
    void trashANow() {
        Destroy (gameObject);
        if (hasKayaOnA) {
            kayaspreadclick.destroyKayaA = true;
        }
        if (hasButterOnA) {
            butterspreadclick.destroyButterA = true;
        }
        resetA();
    }
    
    /* Destroy toast object on position B of board during serving and trashing mechanisms.
    */
    void trashBNow() {
        Destroy (gameObject);
        if (hasKayaOnB) {
            kayaspreadclick.destroyKayaB = true;
        }
        if (hasButterOnB) {
            butterspreadclick.destroyButterB = true;
        }
        resetB();
    }

    /* Checks if toast moving to position A of board has been cooked or burnt.
    */
    void checkIfCookedWellA() { 
        //toast is going to A, but dont know where it is on grill ==> end goal is ToastOnBoardAIsCooked
        if (((isOnGrillA()) && (toastAIsCooked) && (!toastAIsBurnt)) ||
            ((isOnGrillB()) && (toastBIsCooked) && (!toastBIsBurnt))) {
            toastOnBoardAIsCooked = true;
        }
    }

    /* Checks if toast moving to position B of board has been cooked or burnt.
    */
    void checkIfCookedWellB() { 
        //toast is going to B, but dont know where it is on grill ==> end goal is ToastOnBoardBIsCooked
        if (((isOnGrillA()) && (toastAIsCooked) && (!toastAIsBurnt)) ||
            ((isOnGrillB()) && (toastBIsCooked) && (!toastBIsBurnt))) {
            toastOnBoardBIsCooked = true;
        }
    }


    /* Resets variables of grill where toast was previously on, so that a new toast can be instantiated there.
    */
    void resetAfterMoving() {
        if (isOnGrillA()) {
            gameflow.toastOnGrillA = false;
            gameflow.destroySteamA = true;
            toastInner.resetA();
            toastAIsCooked = false;
            toastAIsBurnt = false;
            cookingTimeA = 0;
        } else { //if on grill B
            gameflow.toastOnGrillB = false;
            gameflow.destroySteamB = true;
            toastInner.resetB();
            toastBIsCooked = false;
            toastBIsBurnt = false;
            cookingTimeB = 0;

        }
    }

    /* Resets variables of position A on board where toast was previously on, so that a new toast can be instantiated there.
    */
    void resetA() {
        hasKayaOnA = false;
        hasButterOnA = false;
        toastOnBoardAIsCooked = false;
        isToastAReady = false;
        gameflow.toastOnBoardA = false;
    }

    /* Resets variables of position B on board where toast was previously on, so that a new toast can be instantiated there.
    */
    void resetB() {
        hasKayaOnB = false;
        hasButterOnB = false;
        toastOnBoardBIsCooked = false;
        isToastBReady = false;
        gameflow.toastOnBoardB = false;
    }

    /* Destroys all toast ingredients and objects on position A of board when dish is successfully served. 
    */
    void serveA() {
        if (transform.position == gameflow.boardACoordinates) {
            Destroy (gameObject);
            kayaspreadclick.destroyKayaA = true;
            butterspreadclick.destroyButterA = true;
            serveToastA = false;
            resetA();
        }
    }

    /* Destroys all toast ingredients and objects on position B of board when dish is successfully served. 
    */
    void serveB() {
        if (transform.position == gameflow.boardBCoordinates) {
            Destroy (gameObject);
            kayaspreadclick.destroyKayaB = true;
            butterspreadclick.destroyButterB = true;
            serveToastB = false;
            resetB();
        }
    }


    bool isOnBoard() {
        return ((isOnBoardA()) || (isOnBoardB()));
    }
    
    bool isOnBoardA() {
        return transform.position == gameflow.boardACoordinates;
    }
    
    bool isOnBoardB() {
        return transform.position == gameflow.boardBCoordinates;
    }
    
    bool isOnGrill() {
        return ((isOnGrillA()) || (isOnGrillB()));
    }

    bool isOnGrillA() {
        return transform.position == gameflow.grillACoordinates;
    }

    bool isOnGrillB() {
        return transform.position == gameflow.grillBCoordinates;
    }

    Vector3 newKayaPosition() { 
        return transform.position + gameflow.addKayaCoordinates;
    }

    Vector3 newButterPosition() {
        return transform.position + gameflow.addButterCoordinates;
    }
}
