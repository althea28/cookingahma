using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/*Part of pulut hitam dish. Supports:
 * (i) Adding coconut milk
 * (ii) Trashing and serving dish.
*/
public class cookedPulut : MonoBehaviour
{
    public Transform milkObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    /* Destroys pulut hitam objects when called
    */
    void Update()
    {
        if ((gameflow3.destroyPulutA) && (isOnBowlA())) {

            checkMilkA();
            /*if (gameflow3.milkAddedOnA) {
              milk.destroyA = true;
              }*/

            Destroy (gameObject);
            gameflow3.destroyPulutA = false;
            resetA();

        } else if ((gameflow3.destroyPulutB) && (isOnBowlB())) {

            checkMilkB();
            /*if (gameflow3.milkAddedOnB) {
              milk.destroyB = true;
              }*/

            Destroy (gameObject);
            gameflow3.destroyPulutB = false;
            resetB();
        } 
    }
    
    /*Supports:
     * (i) Adding milk
     * (ii) trashing and serving mechanism
     */
    void OnMouseDown() {
        if ((gameflow3.milkIsClicked) && (canAddMilk())) {
            Instantiate(milkObj, transform.position + gameflow3.addMilkCoords, milkObj.rotation);
            addedMilk();

            //reset
            gameflow3.bowlAClicked = false;
            gameflow3.bowlBClicked = false;

        } else if (isOnBowlA()) {
            gameflow3.bowlAClicked = true;

            //reset
            gameflow3.bowlBClicked = false;

        } else if (isOnBowlB()) {
            gameflow3.bowlBClicked = true;

            //reset
            gameflow3.bowlAClicked = false;
        }

        //reset
        gameflow3.milkIsClicked = false;
        gameflow3.resetClicksOndeh = true;
    }
    
    /*Check if milk has been added to bowl A. If it has, destroy it.
     * Used in trashing and serving mechanism.
    */
    void checkMilkA() {
        if (gameflow3.milkAddedOnA) {
            milk.destroyA = true;
        } 
    } 

    /*Check if milk has been added to bowl B. If it has, destroy it.
     * Used in trashing and serving mechanism.
    */
    void checkMilkB() {
        if (gameflow3.milkAddedOnB) {
            milk.destroyB = true;
        } 
    }

    /* Reset variables on bowl A so that new pulut hitam can be moved here.
    */
    void resetA() {
        gameflow3.bowlAOccupied = false;
        gameflow3.bowlACooked = false;
        gameflow3.milkAddedOnA = false;
    }
    /* Reset variables on bowl B so that new pulut hitam can be moved here.
    */
    void resetB() {
        gameflow3.bowlBOccupied = false;
        gameflow3.bowlBCooked = false;
        gameflow3.milkAddedOnB = false;
    }

    /* Indicate in gameflow3 that milk has been added. So that:
     * (i) prevent repeated addition of milk to pulut hitam.
     * (ii) milk can be destroyed in trashing/serving mechanism.
     */
    void addedMilk() {
        if (isOnBowlA()) {
            gameflow3.milkAddedOnA = true;
        } else if (isOnBowlB()) {
            gameflow3.milkAddedOnB = true;
        }
    }
    /*Checks if milk has already been added
    */
    bool canAddMilk() {
        if (isOnBowlA()) {
            return !gameflow3.milkAddedOnA;
        } else { //is on bowl B
            return !gameflow3.milkAddedOnB;
        }
    }
    bool isOnBowlA() {
        return transform.position == gameflow3.bowlACoords + gameflow3.addPulutCoords;
    }
    bool isOnBowlB() {
        return transform.position == gameflow3.bowlBCoords + gameflow3.addPulutCoords;
    }

}

