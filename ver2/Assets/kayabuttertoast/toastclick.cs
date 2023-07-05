using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastclick : MonoBehaviour
{

    public Transform kayaObj;
    public Transform butterObj;
    public Transform steamObj;

    private static string hasKayaOnA = "n";
    private static string hasKayaOnB = "n";
    private static string hasButterOnA = "n";
    private static string hasButterOnB = "n";

    public float cookingTimeA = 0;
    public float cookingTimeB = 0;
    public static string toastAIsCooked = "n";
    public static string toastBIsCooked = "n";
    public static string toastAIsBurnt = "n";
    public static string toastBIsBurnt = "n";
    private float timeForToastToCook = 3;
    private float timeForToastToBurn = 5; //shld b 10 but change to 5 for faster debugging

    //toastAIsCooked is for material change. toastOnBoardAIsCooked is for when checking if dish is correct
    public static string toastOnBoardAIsCooked = "n";     
    public static string toastOnBoardBIsCooked = "n";
    public static string isToastAReady = "n";
    public static string isToastBReady = "n";

    public static string serveToastA = "n";
    public static string serveToastB = "n";

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(steamObj, transform.position, steamObj.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //check if toast can be served     
        if ((toastOnBoardAIsCooked == "y") && (hasKayaOnA == "y") && (hasButterOnA == "y")) {
            isToastAReady = "y";
        }
        if ((toastOnBoardBIsCooked == "y") && (hasKayaOnB == "y") && (hasButterOnB == "y")) {
            isToastBReady = "y";
        }

        //check to trash
        if ((gameflow.trashA == "y") && (transform.position == gameflow.boardACoordinates)) {
            trashANow();
            gameflow.trashA = "n";
        }
        if ((gameflow.trashB == "y") && (transform.position == gameflow.boardBCoordinates)) {
            trashBNow();
            gameflow.trashB = "n";
        }
                

        if (isOnGrillA()) {
            cookingTimeA += Time.deltaTime;
            if (cookingTimeA > timeForToastToCook) { 
                toastAIsCooked = "y";
            }
            if (cookingTimeA > timeForToastToBurn) {
                toastAIsBurnt = "y";
            }
        } else if (isOnGrillB()) {
            cookingTimeB += Time.deltaTime;
            if (cookingTimeB > timeForToastToCook) {
                toastBIsCooked = "y";
            }
            if (cookingTimeB > timeForToastToBurn) {
                toastBIsBurnt = "y";
            }
        }

        if (serveToastA == "y") {
            serveA();
        } else if (serveToastB == "y") {
            serveB();
        }

    }

    void OnMouseDown() {
        
        //in case of double click. needs to b at the top
        if ((gameflow.toastAIsClicked == "y") || (gameflow.toastBIsClicked == "y")) {
            gameflow.toastAIsClicked = "n";
            gameflow.toastBIsClicked = "n";
        }

        if ((isOnBoard()) && (gameflow.placeButter == "n") && (gameflow.placeKaya == "n")) {
            if (isOnBoardA()) {
                gameflow.toastAIsClicked = "y";
                
                //RESET===
                gameflow.toastBIsClicked = "n";

            } else {
                gameflow.toastBIsClicked = "y";

                //RESET===
                gameflow.toastAIsClicked = "n";

            }

        } else if ((gameflow.placeKaya == "y") && (isOnBoard())) { //placing kaya && toast on board
            if ((isOnBoardA()) && (hasKayaOnA == "n")) {
                hasKayaOnA = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "n")) { 
                hasKayaOnB = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            }

            //RESET=== 
            gameflow.toastAIsClicked = "n";
            gameflow.toastBIsClicked = "n";
            gameflow.placeButter = "n";


        } else if ((gameflow.placeButter == "y")  && (isOnBoard())) { //placing butter && toast on board
            if ((isOnBoardA()) && (hasKayaOnA == "y") && (hasButterOnA == "n")) {
                hasButterOnA = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "y") && (hasButterOnB == "n")) {
                hasButterOnB = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            } 

            //RESET=== 
            gameflow.toastAIsClicked = "n";
            gameflow.toastBIsClicked = "n";
            gameflow.placeKaya = "n";

        } else if ((isOnGrill()) && (gameflow.toastOnBoardA == "n")) { //moving from grill to boardA
            checkIfCookedWellA();
            resetAfterMoving();
            GetComponent<Transform> ().position = gameflow.boardACoordinates;
            gameflow.toastOnBoardA = "y";

            //RESET=== 
            gameflow.resetClicksToast = true;

        } else if ((isOnGrill()) && (gameflow.toastOnBoardB == "n")) { //moving from grill to boardB
            checkIfCookedWellB();
            resetAfterMoving();
            GetComponent<Transform> ().position = gameflow.boardBCoordinates;
            gameflow.toastOnBoardB = "y";

            
            //RESET=== 
            gameflow.resetClicksToast = true;

        }
        
        //RESET===
        gameflow.resetClicksEggs = true;

    }

    void trashANow() {
        Destroy (gameObject);
        if (hasKayaOnA == "y") {
            kayaspreadclick.destroyKayaA = "y";
        }
        if (hasButterOnA == "y") {
            butterspreadclick.destroyButterA = "y";
        }
        resetA();
    }

    void trashBNow() {
        Destroy (gameObject);
        if (hasKayaOnB == "y") {
            kayaspreadclick.destroyKayaB = "y";
        }
        if (hasButterOnB == "y") {
            butterspreadclick.destroyButterB = "y";
        }
        resetB();
    }



    void checkIfCookedWellA() { 
        //toast is going to A, but dont know where it is on grill ==> end goal is ToastOnBoardAIsCooked
        if (((isOnGrillA()) && (toastAIsCooked == "y") && (toastAIsBurnt == "n")) ||
            ((isOnGrillB()) && (toastBIsCooked == "y") && (toastBIsBurnt == "n"))) {
            toastOnBoardAIsCooked = "y";
        }
    }

    void checkIfCookedWellB() { 
        //toast is going to B, but dont know where it is on grill ==> end goal is ToastOnBoardBIsCooked
        if (((isOnGrillA()) && (toastAIsCooked == "y") && (toastAIsBurnt == "n")) ||
            ((isOnGrillB()) && (toastBIsCooked == "y") && (toastBIsBurnt == "n"))) {
            toastOnBoardBIsCooked = "y";
        }
    }


    void resetAfterMoving() {
        if (isOnGrillA()) {
            gameflow.toastOnGrillA = "n";
            gameflow.destroySteamA = "y";
            toastInner.resetA();
            toastAIsCooked = "n";
            toastAIsBurnt = "n";
            cookingTimeA = 0;
        } else { //if on grill B
            gameflow.toastOnGrillB = "n";
            gameflow.destroySteamB = "y";
            toastInner.resetB();
            toastBIsCooked = "n";
            toastBIsBurnt = "n";
            cookingTimeB = 0;

        }
    }

    void resetA() {
        hasKayaOnA = "n";
        hasButterOnA = "n";
        toastOnBoardAIsCooked = "n";
        isToastAReady = "n";
        gameflow.toastOnBoardA = "n";
    }

    void resetB() {
        hasKayaOnB = "n";
        hasButterOnB = "n";
        toastOnBoardBIsCooked = "n";
        isToastBReady = "n";
        gameflow.toastOnBoardB = "n";
    }

    void serveA() {
        if (transform.position == gameflow.boardACoordinates) {
            Destroy (gameObject);
            kayaspreadclick.destroyKayaA = "y";
            butterspreadclick.destroyButterA = "y";
            serveToastA = "n";
            resetA();
        }
    }

    void serveB() {
        if (transform.position == gameflow.boardBCoordinates) {
            Destroy (gameObject);
            kayaspreadclick.destroyKayaB = "y";
            butterspreadclick.destroyButterB = "y";
            serveToastB = "n";
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
