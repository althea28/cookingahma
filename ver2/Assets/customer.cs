using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer : MonoBehaviour
{
    public Transform toastReqObj;
    public Transform eggReqObj;

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1,gameflow.numOfDishes + 1); //change to 3 when add egg
        if (dishSelector == 1) { //if toast
            Instantiate(toastReqObj, transform.position + gameflow.addReqCoordinates, toastReqObj.rotation);
            dishIndicator("toast");
        } else if (dishSelector == 2) {
            Instantiate(eggReqObj, transform.position + gameflow.addReqCoordinates, eggReqObj.rotation);
            dishIndicator("eggs");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        //check if toast is finished
        if ((customersOrder() == "toast") && (gameflow.toastAIsClicked == "y") && (toastclick.isToastAReady == "y")) {
            toastclick.serveToastA = "y"; //triggers serveA() in toastclick.update()
            successfulServe();
            
        } else if ((customersOrder() == "toast") && (gameflow.toastBIsClicked == "y") && (toastclick.isToastBReady == "y"))  {
            toastclick.serveToastB = "y"; //triggers serveB() in toastclick.update()
            successfulServe();
            
        } else if ((customersOrder() == "eggs") && (gameflow.plateAClicked) && 
                (gameflow.plateACooked) && (gameflow.hasSoyaOnA)) {
            gameflow.serveEggA = true;
            successfulServe();

        } else if ((customersOrder() == "eggs") && (gameflow.plateBClicked) && 
                (gameflow.plateBCooked) && (gameflow.hasSoyaOnB)) {
            gameflow.serveEggB = true;
            successfulServe();
        }

        //Debug.Log("Current value of customersServed: " + gameflow.customersServed);
        
        //RESET===
        gameflow.resetClicks = true;

        /*gameflow.toastAIsClicked = "n";
        gameflow.toastBIsClicked = "n";
        gameflow.plateAClicked = false;
        gameflow.plateBClicked = false;*/

        }

    void successfulServe() { 
        destroyReq();
        customerReset(transform.position);
        gameflow.customersServed += 1;
        Destroy (gameObject);
    }

    void customerReset(Vector3 coords) {
        if (coords == gameflow.customerACoordinates) {
            gameflow.customerOnA = "n";
            gameflow.dishOnA = "none";
        } else if (coords == gameflow.customerBCoordinates) {
            gameflow.customerOnB = "n";
            gameflow.dishOnB = "none";
        } else if (coords == gameflow.customerCCoordinates) {
            gameflow.customerOnC = "n";
            gameflow.dishOnC = "none";
        }
    }

    void destroyReq() {
        if (transform.position == gameflow.customerACoordinates) {
            toastReq.destroyA = "y";
        } else if (transform.position == gameflow.customerBCoordinates) {
            toastReq.destroyB = "y";
        } else if (transform.position == gameflow.customerCCoordinates) {
            toastReq.destroyC = "y";
        }
    }

    void dishIndicator(string dish) {
        if (transform.position == gameflow.customerACoordinates) {
            gameflow.dishOnA = dish;
        } else if (transform.position == gameflow.customerBCoordinates) {
            gameflow.dishOnB = dish;
        } else if (transform.position == gameflow.customerCCoordinates) {
            gameflow.dishOnC = dish;
        }
    }

    string customersOrder() {
        if (transform.position == gameflow.customerACoordinates) {
            return gameflow.dishOnA;
        } else if (transform.position == gameflow.customerBCoordinates) {
            return gameflow.dishOnB;
        } else if (transform.position == gameflow.customerCCoordinates) {
            return gameflow.dishOnC;
        } else {
            return "none"; //need placeholder to ensure non null return
        }
    }




}
