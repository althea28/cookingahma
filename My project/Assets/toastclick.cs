using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toastclick : MonoBehaviour
{

    public Transform kayaObj;
    public Transform butterObj;

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



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        //GetComponent<Transform> ().position = new Vector3(2.9f,3.082f,3.366f);
        //for reference, x coords are: boardA=2.9, boardB=0.52, grillA= -2.15f, grillB= -3.94
       
        if ((gameflow.placeKaya == "y") && (isOnBoard())) { //placing kaya && toast on board
            if ((isOnBoardA()) && (hasKayaOnA == "n")) {
                hasKayaOnA = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "n")) {
                hasKayaOnB = "y";
                Instantiate(kayaObj, newKayaPosition(), kayaObj.rotation);
            }

        } else if ((gameflow.placeButter == "y")  && (isOnBoard())) { //placing butter && toast on board
            if ((isOnBoardA()) && (hasKayaOnA == "y") && (hasButterOnA == "n")) {
                hasButterOnA = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            } else if ((isOnBoardB()) && (hasKayaOnB == "y") && (hasButterOnB == "n")) {
                hasButterOnB = "y";
                Instantiate(butterObj, newButterPosition(), butterObj.rotation);
            } 

        } else if ((isOnGrill()) && (gameflow.toastOnBoardA == "n")) { //moving from grill to boardA
            if (isOnGrillA()) {
                gameflow.toastOnGrillA = "n";
            } else {
                gameflow.toastOnGrillB = "n";
            }
            GetComponent<Transform> ().position = boardACoordinates;
            gameflow.toastOnBoardA = "y";

        } else if ((isOnGrill()) && (gameflow.toastOnBoardB == "n")) { //moving from grill to boardB
            if (isOnGrillA()) {
                gameflow.toastOnGrillA = "n";     
            } else {
                gameflow.toastOnGrillB = "n";
            }
            GetComponent<Transform> ().position = boardBCoordinates;
            gameflow.toastOnBoardB = "y";
        
        /*} else if (gameflow.toastOnBoardA == "y" && gameflow.placeKaya == "n" && gameflow.placeButter == "n") { 
            //serving completed dish. But how to shift the kaya n butter :( 
            GetComponent<Transform>().position = new Vector3(2, 5.2f, 0);
            kayaObj.transform.position = new Vector3(2, 5.4f, 0);
            butterObj.transform.position = new Vector3(2, 5.5f, 0);
            gameflow.toastOnBoardA = "n";*/
        }
        //reset, so don't get trapped
        gameflow.placeButter = "n";
        gameflow.placeKaya = "n";
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

    Vector3 newKayaPosition() {
        return transform.position + new Vector3(0.01f, 0.182f, 0.032f);
    }

    Vector3 newButterPosition() {
        return transform.position + new Vector3(0.005f, 0.247f, 0.129f);
    }
}
