using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

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
            Instantiate(ckReqObj, transform.position + customerGenerator.addReqCoordinates, ckReqObj.rotation);
            dishIndicator(ckName);
        } else if (dishSelector == rojakDish) {
            Instantiate(rojakReqObj, transform.position + customerGenerator.addReqCoordinates, rojakReqObj.rotation); 
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
        if (coords == customerGenerator.customerACoordinates) {
            customerGenerator.customerOnA = false;
            gameflow2.dishOnA = "none";
        } else if (coords == customerGenerator.customerBCoordinates) {
            customerGenerator.customerOnB = false;
            gameflow2.dishOnB = "none";
        } else if (coords == customerGenerator.customerCCoordinates) {
            customerGenerator.customerOnC = false;
            gameflow2.dishOnC = "none";
        }
    }

    void destroyReq() {
        if (transform.position == customerGenerator.customerACoordinates) {
            ckReq.destroyA = true;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            ckReq.destroyB = true;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            ckReq.destroyC = true;
        }
    }

    void dishIndicator(string dish) {
        if (transform.position == customerGenerator.customerACoordinates) {
            gameflow2.dishOnA = dish;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            gameflow2.dishOnB = dish;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            gameflow2.dishOnC = dish;
        }
    }

    string customersOrder() {
        if (transform.position == customerGenerator.customerACoordinates) {
            return gameflow2.dishOnA;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            return gameflow2.dishOnB;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            return gameflow2.dishOnC;
        } else {
            return "none"; //need placeholder to ensure non null return
        }
    }

}
