using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer2 : MonoBehaviour
{
    public Transform ckReqObj;
    public Transform rojakReqObj;

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1,gameflow2.numOfDishes + 1); 
        if (dishSelector == 1) { //if chweekueh
            Instantiate(ckReqObj, transform.position + gameflow2.addReqCoordinates, ckReqObj.rotation);
            dishIndicator("chweekueh");
        } else if (dishSelector == 2) {
            Instantiate(rojakReqObj, transform.position + gameflow.addReqCoordinates, rojakReqObj.rotation); 
            dishIndicator("rojak");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        //check if toast is finished
        if ((customersOrder() == "chweekueh") && (gameflow2.plateAClicked) && 
            (gameflow2.plateACooked) && (gameflow2.hasCPOnA)) {
            gameflow2.serveCkA = true; 
            successfulServe();
            
        } else if ((customersOrder() == "chweekueh") && (gameflow2.plateBClicked) && 
            (gameflow2.plateBCooked) && (gameflow2.hasCPOnB)) {
            gameflow2.serveCkB = true; 
            successfulServe();

        } else if ((customersOrder() == "rojak") && (gameflow2.bowlAClicked) && (gameflow2.stepOnBowlA == 5)) {
            gameflow2.stepOnBowlA = 1;
            gameflow2.serveRojakA = true;
            successfulServe();

        } else if ((customersOrder() == "rojak") && (gameflow2.bowlBClicked) && (gameflow2.stepOnBowlB == 5)) {
            gameflow2.stepOnBowlB = 1;
            gameflow2.serveRojakB = true;
            successfulServe();
        }
        
        //RESET===
        gameflow2.resetClicks = true;
    }

    void successfulServe() { 
        destroyReq();
        customerReset(transform.position);
        gameflow2.customersServed += 1;
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
