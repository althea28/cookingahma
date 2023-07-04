using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer2 : MonoBehaviour
{
    public Transform ckReqObj;

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1,gameflow2.numOfDishes + 1); 
        if (dishSelector == 1) { //if chweekueh
            Instantiate(ckReqObj, transform.position + gameflow2.addReqCoordinates, ckReqObj.rotation);
            dishIndicator("chweekueh");
        } else if (dishSelector == 2) {
            //Instantiate(eggReqObj, transform.position + gameflow.addReqCoordinates, eggReqObj.rotation); 
            //change eggReq to rojakReq
            dishIndicator("rojak");
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
        
        //RESET===
        gameflow.resetClicks = true;
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
            toastReq.destroyA = "y";
        } else if (transform.position == gameflow2.customerBCoordinates) {
            toastReq.destroyB = "y";
        } else if (transform.position == gameflow2.customerCCoordinates) {
            toastReq.destroyC = "y";
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
