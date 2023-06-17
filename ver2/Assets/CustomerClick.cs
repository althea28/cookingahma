using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerClick : MonoBehaviour
{

    void OnMouseDown() {
        Debug.Log("Click");
        if (gameflow.isToastClicked == "y")
        {
            Debug.Log("Customer clciekd");
            gameflow.isCustomerClicked = "y";
            gameflow.destroyToast = "y";
            Destroy (gameObject);
            Debug.Log("customer destroyed");
            //Destroy (kaya);
            //Destroy (butter);
        }
        gameflow.isToastClicked = "n";
    }

    void Update() {

    }

}






