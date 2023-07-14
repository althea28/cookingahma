using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer3 : MonoBehaviour
{
    public Transform ondehReqObj;
    //public Transform rojakReqObj;

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1,gameflow2.numOfDishes + 1); 
        if (dishSelector == 1) { //if ondeh
            Instantiate(ondehReqObj, transform.position + gameflow2.addReqCoordinates, ondehReqObj.rotation);
            dishIndicator("ondeh");
        /*} else if (dishSelector == 2) {
            Instantiate(rojakReqObj, transform.position + gameflow.addReqCoordinates, rojakReqObj.rotation); 
            dishIndicator("rojak");*/
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        
        //serve ondeh A
        if ((customersOrder() == "ondeh") && (gameflow3.ondehPlateAClicked) && 
                (gameflow3.ondehOnACooked) && (gameflow3.coconutOnA)) {
            gameflow3.destroyOndehA = true; 
            successfulServe();
            
        //serve ondeh B
        } else if ((customersOrder() == "ondeh") && (gameflow3.ondehPlateBClicked) && 
                (gameflow3.ondehOnBCooked) && (gameflow3.coconutOnB)) {
            gameflow3.destroyOndehB = true; 
            successfulServe();

        /*} else if ((customersOrder() == "rojak") && (gameflow2.bowlAClicked) && (gameflow2.stepOnBowlA == 5)) {
            gameflow2.stepOnBowlA = 1;
            gameflow2.serveRojakA = true;
            successfulServe();

        } else if ((customersOrder() == "rojak") && (gameflow2.bowlBClicked) && (gameflow2.stepOnBowlB == 5)) {
            gameflow2.stepOnBowlB = 1;
            gameflow2.serveRojakB = true;
            successfulServe();*/
        }
        
        //RESET===
        gameflow3.resetClicksOndeh = true;
    }

    void successfulServe() { 
        destroyReq();
        customerReset();
        gameflow3.customersServed += 1;
        Destroy (gameObject);
    }

    void customerReset() {
        if (transform.position == gameflow3.customerACoordinates) {
            gameflow3.customerOnA = false;
            gameflow3.dishOnA = "none";
        } else if (transform.position == gameflow3.customerBCoordinates) {
            gameflow3.customerOnB = false;
            gameflow3.dishOnB = "none";
        } else if (transform.position == gameflow3.customerCCoordinates) {
            gameflow3.customerOnC = false;
            gameflow3.dishOnC = "none";
        }
    }

    void destroyReq() {
        if (transform.position == gameflow3.customerACoordinates) {
            dishReq.destroyA = true;
        } else if (transform.position == gameflow3.customerBCoordinates) {
            dishReq.destroyB = true;
        } else if (transform.position == gameflow3.customerCCoordinates) {
            dishReq.destroyC = true;
        }
    }

    void dishIndicator(string dish) {
        if (transform.position == gameflow3.customerACoordinates) {
            gameflow3.dishOnA = dish;
        } else if (transform.position == gameflow3.customerBCoordinates) {
            gameflow3.dishOnB = dish;
        } else if (transform.position == gameflow3.customerCCoordinates) {
            gameflow3.dishOnC = dish;
        }
    }

    string customersOrder() {
        if (transform.position == gameflow3.customerACoordinates) {
            return gameflow3.dishOnA;
        } else if (transform.position == gameflow3.customerBCoordinates) {
            return gameflow3.dishOnB;
        } else { //is customerC
            return gameflow3.dishOnC;
        }
    }

}
