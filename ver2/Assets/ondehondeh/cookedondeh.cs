using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookedondeh : MonoBehaviour
{
    public Transform coconutObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((gameflow3.destroyOndehA) && (isOnPlateA())) {

            checkCoconutA();
            /*if (gameflow3.coconutOnA) {
              cookedcoconut.destroyA = true;
              gameflow3.coconutOnA = false;
              }*/
            gameflow3.destroyOndehA = false;
            resetA();
            Destroy(gameObject);
        }
        if ((gameflow3.destroyOndehB) && (isOnPlateB())) {

            checkCoconutB();
            /*if (gameflow3.coconutOnB) {
              cookedcoconut.destroyB = true;
              gameflow3.coconutOnB = false;
              }*/
            gameflow3.destroyOndehB = false;
            resetB();
            Destroy(gameObject);

        }

    }

    void OnMouseDown() {
        //adding coconut
        if ((gameflow3.coconutClicked) && (noCoconutOnPlate())) {
            Instantiate(coconutObj, transform.position + gameflow3.addCoconutCoords, coconutObj.rotation);
            addedCoconut();

            //reset
            gameflow3.ondehPlateAClicked = false;
            gameflow3.ondehPlateBClicked = false;

            //click plate
        } else if (isOnPlateA()) {
            Debug.Log("is on plate A");
            gameflow3.ondehPlateAClicked = true;

            //reset
            gameflow3.ondehPlateBClicked = false;

        } else if (isOnPlateB()) {
            gameflow3.ondehPlateBClicked = true;

            //reset
            gameflow3.ondehPlateAClicked = false;
        }

        //reset
        gameflow3.coconutClicked = false;
        gameflow3.resetClicksPulut = true;
    }

    void checkCoconutA() {
        if (gameflow3.coconutOnA) {
            cookedcoconut.destroyA = true;
            gameflow3.coconutOnA = false;
        }
    }
    void checkCoconutB() {
        if (gameflow3.coconutOnB) {
            cookedcoconut.destroyB = true;
            gameflow3.coconutOnB = false;
        }
    }


    void resetA() {
        gameflow3.ondehOnPlateA = false;
        gameflow3.ondehOnACooked = false;
    }
    void resetB() {
        gameflow3.ondehOnPlateB = false;
        gameflow3.ondehOnBCooked = false;
    }


    void addedCoconut() {
        if (isOnPlateA()) {
            gameflow3.coconutOnA = true;
        } else if (isOnPlateB()) {
            gameflow3.coconutOnB = true;
        }
    }

    bool noCoconutOnPlate() {
        if (isOnPlateA()) {
            return !gameflow3.coconutOnA;
        } else { //isOnPlateB
            return !gameflow3.coconutOnB;
        }
    }

    bool isOnPlateA() {
        return transform.position == gameflow3.plateACoords + gameflow3.cookedOndehCoords;
    }
    bool isOnPlateB() {
        return transform.position == gameflow3.plateBCoords + gameflow3.cookedOndehCoords;
    }

}
