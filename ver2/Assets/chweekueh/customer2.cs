using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer2 : MonoBehaviour
{
    public Transform ckReqObj;
    public Transform rojakReqObj;

    private int ckDish = 1;
    private int rojakDish = 2;
    
    private string ckName = "chweekueh";
    private string rojakName = "rojak";

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1,gameflow2.numOfDishes + 1); 
        if (dishSelector == ckDish) { //if chweekueh
            Instantiate(ckReqObj, transform.position + gameflow2.addReqCoordinates, ckReqObj.rotation);
            dishIndicator(ckName);
        } else if (dishSelector == rojakDish) {
            Instantiate(rojakReqObj, transform.position + gameflow.addReqCoordinates, rojakReqObj.rotation); 
            dishIndicator(rojakName);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        //check if toast is finished
        if ((customersOrder() == ckName) && (gameflow2.plateAClicked) && 
            (gameflow2.plateACooked) && (gameflow2.hasCPOnA)) {
            gameflow2.serveCkA = true; 
            successfulServe();
            
        } else if ((customersOrder() == ckName) && (gameflow2.plateBClicked) && 
            (gameflow2.plateBCooked) && (gameflow2.hasCPOnB)) {
            gameflow2.serveCkB = true; 
            successfulServe();

        } else if ((customersOrder() == rojakName) && (gameflow2.bowlAClicked) && (gameflow2.stepOnBowlA == gameflow2.stepReadyPlate)) {
            gameflow2.stepOnBowlA = gameflow2.stepEmptyPlate;
            gameflow2.serveRojakA = true;
            successfulServe();

        } else if ((customersOrder() == rojakName) && (gameflow2.bowlBClicked) && (gameflow2.stepOnBowlB == gameflow2.stepReadyPlate)) {
            gameflow2.stepOnBowlB = gameflow2.stepEmptyPlate;
            gameflow2.serveRojakB = true;
            successfulServe();
        }
        
        //RESET===
        gameflow2.resetClicks = true;
    }

    void successfulServe() { 
        destroyReq();
        customerReset(transform.position);
        gameflow2.customersServed ++;
        Destroy (gameObject);
    }

    void customerReset(Vector3 coords) {
        if (coords == gameflow2.customerACoordinates) {
            gameflow2.customerOnA = "n";
            gameflow2.dishOnA = "none";
        } else if (coords == gameflow2.customerBCoordinates) {
            gameflow2.customerOnB = "n";
            gameflow2.dishOnB = "none";
        } else if (coords == gameflow2.customerCCoordinates) {
            gameflow2.customerOnC = "n";
            gameflow2.dishOnC = "none";
        }
    }

    void destroyReq() {
        if (transform.position == gameflow2.customerACoordinates) {
            ckReq.destroyA = "y";
        } else if (transform.position == gameflow2.customerBCoordinates) {
            ckReq.destroyB = "y";
        } else if (transform.position == gameflow2.customerCCoordinates) {
            ckReq.destroyC = "y";
        }
    }

    void dishIndicator(string dish) {
        if (transform.position == gameflow2.customerACoordinates) {
            gameflow2.dishOnA = dish;
        } else if (transform.position == gameflow2.customerBCoordinates) {
            gameflow2.dishOnB = dish;
        } else if (transform.position == gameflow2.customerCCoordinates) {
            gameflow2.dishOnC = dish;
        }
    }

    string customersOrder() {
        if (transform.position == gameflow2.customerACoordinates) {
            return gameflow2.dishOnA;
        } else if (transform.position == gameflow2.customerBCoordinates) {
            return gameflow2.dishOnB;
        } else if (transform.position == gameflow2.customerCCoordinates) {
            return gameflow2.dishOnC;
        } else {
            return "none"; //need placeholder to ensure non null return
        }
    }

}
