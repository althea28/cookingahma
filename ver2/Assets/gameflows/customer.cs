using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** customer class is attached to all customers from levels 1 to 3. 
 * customer supports:
 * (i) randomly generating a dish request for each customer
 * (ii) serving a correct dish to a customer
 * (iii) resetting variables in class gameflow and updating game statistics after every successful serving
 */

public class customer : MonoBehaviour
{
    public Transform toastReqObj;
    public Transform eggReqObj;

    private int toastDish = 1;
    private int eggDish = 2;
    private string toastName = "toast";
    private string eggName = "eggs";

    // Start is called before the first frame update
    /* Generates a random dish request when a new customer is instantiated
    */
    void Start()
    {
        int dishSelector = Random.Range(1, customerGenerator.numOfDishes + 1); //change to 3 when add egg
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

    /* Used when player is attempting to serve a customer. 
     * Checks if the dish the player is trying to serve is (i) what the customer ordered (ii) prepared correctly.
    */
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

    /* When a dish is successfully served:
     * (i) variables are reset so that new customer can be instantiated
     * (ii) game statistics are updated
    */
    void successfulServe() { 
        destroyReq();
        customerReset(transform.position);
        gameflow.customersServed += 1;
        Destroy (gameObject);
    }
    
    /* Resets variables so that new customer can be instantiated at this position.
     * @param coords Current coordinates of this customer object.
    */
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

    /* Destroys the dish request model attached to this customer.
    */
    void destroyReq() {
        if (transform.position == customerGenerator.customerACoordinates) {
            toastReq.destroyA = true;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            toastReq.destroyB = true;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            toastReq.destroyC = true;
        }
    }

    /* Indicate in gameflow which dish was randomly chosen when this customer was instantiated.
     * @param dish Passed from Start(), is the string name of the dish chosen.
    */
    void dishIndicator(string dish) {
        if (transform.position == customerGenerator.customerACoordinates) {
            gameflow.dishOnA = dish;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            gameflow.dishOnB = dish;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            gameflow.dishOnC = dish;
        }
    }
    
    /* Retrieves the dish that this customer is ordering, when the player is trying to serve a dish.
     * @return name of dish that this customer is ordering
    */
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
