using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer3 : MonoBehaviour
{
    public Transform ondehReqObj;
    public Transform pulutReqObj;

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1, gameflow3.numOfDishes + 1); 
        if (dishSelector == 1) { //if ondeh
            Instantiate(ondehReqObj, transform.position + gameflow2.addReqCoordinates, ondehReqObj.rotation);
            dishIndicator("ondeh");
        } else if (dishSelector == 2) { //if pulut hitam
            Instantiate(pulutReqObj, transform.position + gameflow.addReqCoordinates, pulutReqObj.rotation); 
            dishIndicator("pulut");
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
        
        //serve pulut A
        } else if ((customersOrder() == "pulut") && (gameflow3.bowlAClicked) && 
                (gameflow3.bowlACooked) && (gameflow3.milkAddedOnA)) {
            gameflow3.destroyPulutA = true;
            successfulServe();
        
        //serve pulut B
        } else if ((customersOrder() == "pulut") && (gameflow3.bowlBClicked) && 
                (gameflow3.bowlBCooked) && (gameflow3.milkAddedOnB)) {
            gameflow3.destroyPulutB = true;
            successfulServe();
        }
        
        //RESET===
        gameflow3.resetClicks = true;
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
