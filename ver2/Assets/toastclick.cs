using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastclick : MonoBehaviour
{

    public Transform kayaObj;
    public Transform butterObj;
    public Transform steamObj;

    private float boardAXCoordinates = 2.9f;
    private float boardBXCoordinates = 0.52f;
    private float grillAXCoordinates = -2.15f;
    private float grillBXCoordinates = -3.94f;
    private Vector3 boardACoordinates = new Vector3(2.9f,3.08f,3.366f);
    private Vector3 boardBCoordinates = new Vector3(0.52f,3.08f,3.366f);


    private static string hasKayaOnA = "n";
    private static string hasKayaOnB = "n";
    private static string hasButterOnA = "n";
    private static string hasButterOnB = "n";

    private GameObject instantiatedKayaObj;

    public float cookingTimeA = 0;
    public float cookingTimeB = 0;
    public static string toastAIsCooked = "n";
    public static string toastBIsCooked = "n";
    public static string toastAIsBurnt = "n";
    public static string toastBIsBurnt = "n";
    private float timeForToastToCook = 3;
    private float timeForToastToBurn = 10;

    public GameObject customer;
    private bool isToastReady = false; 

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(steamObj, transform.position, steamObj.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameflow.isToastClicked =="y") {
            Debug.Log("clicked2");
        }
        if (gameflow.destroyToast == "y" && isToastReady) {
            Debug.Log("toast to serve");
            GetComponent<Transform> ().position = new Vector3(3,3,10); // shift toast out of camera view
            gameflow.destroyKaya = "y"; // change condition to call Update() in kayaspreadclick.cs
            gameflow.destroyButter = "y"; // change condition to call Update() in butterclick.cs
            if (gameflow.toastOnBoardA == "y") {
                gameflow.toastOnBoardA = "n"; 
            } else {
                gameflow.toastOnBoardB = "n";
            }
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

    }

    void OnMouseDown() {
        //GetComponent<Transform> ().position = new Vector3(2.9f,3.082f,3.366f);
        //for reference, x coords are: boardA=2.9, boardB=0.52, grillA= -2.15f, grillB= -3.94
        if (isToastReady) {
            if ((gameflow.isToastClicked == "n")) {
                Debug.Log("clicked");
                gameflow.isToastClicked = "y";
            }
        } else {
            if ((gameflow.placeKaya == "y") && (isOnBoard())) { //placing kaya && toast on board
            if ((isOnBoardA()) && (hasKayaOnA == "n")) {
                hasKayaOnA = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "n")) {
                Debug.Log("B");
                hasKayaOnB = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            }

            } else if ((gameflow.placeButter == "y")  && (isOnBoard())) { //placing butter && toast on board
            isToastReady = true;
            if ((isOnBoardA()) && (hasKayaOnA == "y") && (hasButterOnA == "n")) {
                hasButterOnA = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "y") && (hasButterOnB == "n")) {
                hasButterOnB = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            } 

            } else if ((isOnGrill()) && (gameflow.toastOnBoardA == "n")) { //moving from grill to boardA
            resetAfterMoving();
            GetComponent<Transform> ().position = boardACoordinates;
            gameflow.toastOnBoardA = "y";

            } else if ((isOnGrill()) && (gameflow.toastOnBoardB == "n")) { //moving from grill to boardB
            resetAfterMoving();
            GetComponent<Transform> ().position = boardBCoordinates;
            gameflow.toastOnBoardB = "y";
            }
            gameflow.placeButter = "n";
            gameflow.placeKaya = "n";
        }
        
        /*} else if (gameflow.toastOnBoardA == "y" && gameflow.placeKaya == "n" && gameflow.placeButter == "n") { 
            //serving completed dish. But how to shift the kaya n butter :( 
            GetComponent<Transform>().position = new Vector3(2, 5.2f, 0);
            Instantiate(kayaObj, new Vector3(2,5.4f,0), kayaObj.rotation);
            Instantiate(butterObj, new Vector3(2,5.5f,0), butterObj.rotation);
            gameflow.toastOnBoardA = "y";

        }*/
        //reset, so don't get trapped

    }

    /*void OnMouseUp()
    {
         
        if ((isToastClicked == "y") && (gameflow.isCustomerClicked == "y"))
        {
            ServeToastToCustomer();
        }
    }*/
    /*void ServeToastToCustomer()
    {
        if ((isToastClicked == "y") && (gameflow.isCustomerClicked == "y"))
        {
            Debug.Log("Destroying");
            Destroy(customer);
            Destroy(gameObject);
        }
    }*/

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

    bool isOnBoard() {
        return ((transform.position.x == boardAXCoordinates) || (transform.position.x == boardBXCoordinates));
    }
    
    bool isOnBoardA() {
        return transform.position.x == boardAXCoordinates;
    }
    
    bool isOnBoardB() {
        return transform.position.x == boardBXCoordinates;
    }
    
    bool isOnGrill() {
        return ((transform.position.x == grillAXCoordinates) || (transform.position.x == grillBXCoordinates));
    }

    bool isOnGrillA() {
        return transform.position.x == grillAXCoordinates;
    }

    bool isOnGrillB() {
        return transform.position.x == grillBXCoordinates;
    }

    Vector3 newKayaPosition() { 
        return transform.position + new Vector3(0.01f, 0.182f, 0.032f);
    }
    Vector3 newButterPosition() {
        return transform.position + new Vector3(0.005f, 0.247f, 0.129f);
    }
}