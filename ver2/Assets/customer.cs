using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer : MonoBehaviour
{
    public Transform toastReqObj;
    public Transform eggReqObj;

    private int toastDish = 1;
    private int eggDish = 2;
    private string toastName = "toast";
    private string eggName = "eggs";

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1,gameflow.numOfDishes + 1); //change to 3 when add egg
        if (dishSelector == toastDish) { //if toast
            Instantiate(toastReqObj, transform.position + customerGenerator.addReqCoordinates, toastReqObj.rotation);
            dishIndicator(toastName);
        } else if (dishSelector == eggDish) {
            Instantiate(eggReqObj, transform.position + customerGenerator.addReqCoordinates, eggReqObj.rotation);
            dishIndicator(eggName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        //check if toast is finished
        if ((customersOrder() == toastName) && (gameflow.toastAIsClicked) && (toastclick.isToastAReady)) {
            toastclick.serveToastA = true; //triggers serveA() in toastclick.update()
            successfulServe();
            
        } else if ((customersOrder() == toastName) && (gameflow.toastBIsClicked) && (toastclick.isToastBReady))  {
            toastclick.serveToastB = true; //triggers serveB() in toastclick.update()
            successfulServe();
            
        } else if ((customersOrder() == eggName) && (gameflow.plateAClicked) && 
                (gameflow.plateACooked) && (gameflow.hasSoyaOnA)) {
            gameflow.serveEggA = true;
            successfulServe();

        } else if ((customersOrder() == eggName) && (gameflow.plateBClicked) && 
                (gameflow.plateBCooked) && (gameflow.hasSoyaOnB)) {
            gameflow.serveEggB = true;
            successfulServe();
        }
        
        //RESET===
        gameflow.resetClicks = true;
        }

    void successfulServe() { 
        destroyReq();
        customerReset(transform.position);
        gameflow.customersServed += 1;
        Destroy (gameObject);
    }

    void customerReset(Vector3 coords) {
        if (coords == customerGenerator.customerACoordinates) {
            customerGenerator.customerOnA = false;
            gameflow.dishOnA = "none";
        } else if (coords == customerGenerator.customerBCoordinates) {
            customerGenerator.customerOnB = false;
            gameflow.dishOnB = "none";
        } else if (coords == customerGenerator.customerCCoordinates) {
            customerGenerator.customerOnC = false;
            gameflow.dishOnC = "none";
        }
    }

    void destroyReq() {
        if (transform.position == customerGenerator.customerACoordinates) {
            toastReq.destroyA = true;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            toastReq.destroyB = true;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            toastReq.destroyC = true;
        }
    }

    void dishIndicator(string dish) {
        if (transform.position == customerGenerator.customerACoordinates) {
            gameflow.dishOnA = dish;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            gameflow.dishOnB = dish;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            gameflow.dishOnC = dish;
        }
    }

    string customersOrder() {
        if (transform.position == customerGenerator.customerACoordinates) {
            return gameflow.dishOnA;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            return gameflow.dishOnB;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            return gameflow.dishOnC;
        } else {
            return "none"; //need placeholder to ensure non null return
        }
    }




}
