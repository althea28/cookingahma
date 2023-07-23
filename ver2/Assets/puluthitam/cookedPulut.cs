using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedPulut : MonoBehaviour
{
    public Transform milkObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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

    void checkMilkA() {
        if (gameflow3.milkAddedOnA) {
            milk.destroyA = true;
        } 
    }
    void checkMilkB() {
        if (gameflow3.milkAddedOnB) {
            milk.destroyB = true;
        } 
    }

    void resetA() {
        gameflow3.bowlAOccupied = false;
        gameflow3.bowlACooked = false;
        gameflow3.milkAddedOnA = false;
    }
    void resetB() {
        gameflow3.bowlBOccupied = false;
        gameflow3.bowlBCooked = false;
        gameflow3.milkAddedOnB = false;
    }

    void addedMilk() {
        if (isOnBowlA()) {
            gameflow3.milkAddedOnA = true;
        } else if (isOnBowlB()) {
            gameflow3.milkAddedOnB = true;
        }
    }

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

