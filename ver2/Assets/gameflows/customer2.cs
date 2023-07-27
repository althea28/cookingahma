using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** customer2 class is attached to all customers from levels 4 to 6. 
 * customer2 supports:
 * (i) randomly generating a dish request for each customer
 * (ii) serving a correct dish to a customer
 * (iii) resetting variables in class gameflow and updating game statistics after every successful serving
 */

public class customer2 : MonoBehaviour
{
    public Transform ckReqObj;
    public Transform rojakReqObj;

    private int ckDish = 1;
    private int rojakDish = 2;
    
    private string ckName = "chweekueh";
    private string rojakName = "rojak";

    // Start is called before the first frame update
    /* Generates a random dish request when a new customer is instantiated
    */
    void Start()
    {
        int dishSelector = Random.Range(1,customerGenerator.numOfDishes + 1); 
        if (dishSelector == ckDish) { //if chweekueh
            Instantiate(ckReqObj, transform.position + customerGenerator.addReqCoordinates, ckReqObj.rotation);
            dishIndicator(ckName);
        } else if (dishSelector == rojakDish) {
            Instantiate(rojakReqObj, transform.position + customerGenerator.addReqCoordinates, rojakReqObj.rotation); 
            dishIndicator(rojakName);
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
        if ((customersOrder() == ckName) && (gameflow2.plateAClicked) && 
            (gameflow2.plateACooked) && (gameflow2.hasCPOnA)) {
            gameflow2.serveCkA = true; 
            successfulServe();
            
        } else if ((customersOrder() == ckName) && (gameflow2.plateBClicked) && 
            (gameflow2.plateBCooked) && (gameflow2.hasCPOnB)) {
            gameflow2.serveCkB = true; 
            successfulServe();

        } else if ((customersOrder() == rojakName) && (gameflow2.bowlAClicked) && (gameflow2.stepOnBowlA == gameflow2.stepReadyPlate)) {
            gameflow2.stepOnBowlA = gameflow2.stepEmptyPlate;
            gameflow2.serveRojakA = true;
            successfulServe();

        } else if ((customersOrder() == rojakName) && (gameflow2.bowlBClicked) && (gameflow2.stepOnBowlB == gameflow2.stepReadyPlate)) {
            gameflow2.stepOnBowlB = gameflow2.stepEmptyPlate;
            gameflow2.serveRojakB = true;
            successfulServe();
        }
        
        //RESET===
        gameflow2.resetClicks = true;
    }

    /* When a dish is successfully served:
     * (i) variables are reset so that new customer can be instantiated
     * (ii) game statistics are updated
    */
    void successfulServe() { 
        destroyReq();
        customerReset(transform.position);
        gameflow2.customersServed ++;
        Destroy (gameObject);
    }

    /* Resets variables so that new customer can be instantiated at this position.
     * @param coords Current coordinates of this customer object.
    */
    void customerReset(Vector3 coords) {
        if (coords == customerGenerator.customerACoordinates) {
            customerGenerator.customerOnA = false;
            gameflow2.dishOnA = "none";
        } else if (coords == customerGenerator.customerBCoordinates) {
            customerGenerator.customerOnB = false;
            gameflow2.dishOnB = "none";
        } else if (coords == customerGenerator.customerCCoordinates) {
            customerGenerator.customerOnC = false;
            gameflow2.dishOnC = "none";
        }
    }

    /* Destroys the dish request model attached to this customer.
    */
    void destroyReq() {
        if (transform.position == customerGenerator.customerACoordinates) {
            ckReq.destroyA = true;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            ckReq.destroyB = true;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            ckReq.destroyC = true;
        }
    }

    /* Indicate in gameflow which dish was randomly chosen when this customer was instantiated.
     * @param dish Passed from Start(), is the string name of the dish chosen.
    */
    void dishIndicator(string dish) {
        if (transform.position == customerGenerator.customerACoordinates) {
            gameflow2.dishOnA = dish;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            gameflow2.dishOnB = dish;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            gameflow2.dishOnC = dish;
        }
    }

    /* Retrieves the dish that this customer is ordering, when the player is trying to serve a dish.
     * @return name of dish that this customer is ordering
    */
    string customersOrder() {
        if (transform.position == customerGenerator.customerACoordinates) {
            return gameflow2.dishOnA;
        } else if (transform.position == customerGenerator.customerBCoordinates) {
            return gameflow2.dishOnB;
        } else if (transform.position == customerGenerator.customerCCoordinates) {
            return gameflow2.dishOnC;
        } else {
            return "none"; //need placeholder to ensure non null return
        }
    }

}
