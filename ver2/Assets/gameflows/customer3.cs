using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

public class customer3 : MonoBehaviour
{
    public Transform ondehReqObj;
    public Transform pulutReqObj;
    
    private int ondehDish = 1;
    private int pulutDish = 2;
    private string ondehName = "ondeh";
    private string pulutName = "pulut";

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1, customerGenerator.numOfDishes + 1); 
        if (dishSelector == ondehDish) { //if ondeh
            Instantiate(ondehReqObj, transform.position + customerGenerator.addReqCoordinates, ondehReqObj.rotation);
            dishIndicator(ondehName);
        } else if (dishSelector == pulutDish) { //if pulut hitam
            Instantiate(pulutReqObj, transform.position + customerGenerator.addReqCoordinates, pulutReqObj.rotation); 
            dishIndicator(pulutName);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown() {
        
        //if customer has ordered ondeh ondeh, player has clicked ondeh ondeh on plate A to be served 
        //     and ondeh ondeh on plate A is prepared correctly -> then serve ondeh ondeh A
        if ((customersOrder() == ondehName) && (gameflow3.ondehPlateAClicked) && //
                (gameflow3.ondehOnACooked) && (gameflow3.coconutOnA)) {
            
            //destroy the ondeh ondeh on plate A
            gameflow3.destroyOndehA = true;             

            //update statistics
            successfulServe();

        //if customer has ordered ondeh ondeh, player has clicked ondeh ondeh on plate B to be served 
        //     and ondeh ondeh on plate B is prepared correctly -> then serve ondeh ondeh B
        } else if ((customersOrder() == ondehName) && (gameflow3.ondehPlateBClicked) && 
                (gameflow3.ondehOnBCooked) && (gameflow3.coconutOnB)) {

            //destroy the ondeh ondeh on plate A
            gameflow3.destroyOndehB = true;          

            //update statistics
            successfulServe();
        
        //serve pulut A
        } else if ((customersOrder() == pulutName) && (gameflow3.bowlAClicked) && 
                (gameflow3.bowlACooked) && (gameflow3.milkAddedOnA)) {
            gameflow3.destroyPulutA = true;
            successfulServe();
        
        //serve pulut B
        } else if ((customersOrder() == pulutName) && (gameflow3.bowlBClicked) && 
                (gameflow3.bowlBCooked) && (gameflow3.milkAddedOnB)) {
            gameflow3.destroyPulutB = true;
            successfulServe();
        }
        
        //RESET===
        gameflow3.resetClicks = true;
    }
    
    //player has successfully served a dish -> update game statistics and destroy customer
    void successfulServe() { 

        //destroy the dish req attached to the customer
        destroyReq();

        //signal gameflow to generate another customer at this position
        customerReset();

        //update game statistics to reflect another customer served
        gameflow3.customersServed ++;

        //destroy current customer that has been served
        Destroy (gameObject);
    }

    void customerReset() {
        if (transform.position == customerGenerator.customerACoordinates) {
            customerGenerator.customerOnA = false;
            gameflow3.dishOnA = "none";
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            customerGenerator.customerOnB = false;
            gameflow3.dishOnB = "none";
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            customerGenerator.customerOnC = false;
            gameflow3.dishOnC = "none";
        }
    }

    void destroyReq() {
        if (transform.position == customerGenerator.customerACoordinates) {
            dishReq.destroyA = true;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            dishReq.destroyB = true;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            dishReq.destroyC = true;
        }
    }

    void dishIndicator(string dish) {
        if (transform.position == customerGenerator.customerACoordinates) {
            gameflow3.dishOnA = dish;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            gameflow3.dishOnB = dish;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            gameflow3.dishOnC = dish;
        }
    }

    string customersOrder() {
        if (transform.position == customerGenerator.customerACoordinates) {
            return gameflow3.dishOnA;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            return gameflow3.dishOnB;
        } else { //is customerC
            return gameflow3.dishOnC;
        }
    }

}
