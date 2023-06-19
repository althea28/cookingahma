using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer : MonoBehaviour
{
    public Transform toastReqObj;

    // Start is called before the first frame update
    void Start()
    {
        int dishSelector = Random.Range(1,2); //change to 3 when add egg
        if (dishSelector == 1) {
            Instantiate(toastReqObj, transform.position + gameflow.addReqCoordinates, toastReqObj.rotation);
            dishIndicator("toast");
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        //check if toast is finished
        if ((gameflow.toastAIsClicked == "y") && (toastclick.isToastAReady == "y")) {
            toastclick.serveToastA = "y"; //triggers serveA() in toastclick.update()
            Destroy (gameObject);
            destroyReq();
            customerReset(transform.position);
        } else if ((gameflow.toastBIsClicked == "y") && (toastclick.isToastBReady == "y"))  {
            toastclick.serveToastB = "y"; //triggers serveB() in toastclick.update()
            Destroy (gameObject);
            destroyReq();
            customerReset(transform.position);
        }
        //reset
        gameflow.toastAIsClicked = "n";
        gameflow.toastBIsClicked = "n";
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




}
