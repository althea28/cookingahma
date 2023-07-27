using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of ondeh ondeh dish. Supports:
 * (i) Adding coconut flakes to dish
 * (ii) Trashing mechanism of dish
*/

public class undercookedondeh : MonoBehaviour
{
    public Transform undercookedCoconutObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    /* Destroys ondeh ondeh when trashing
    */
    void Update()
    {
        if ((gameflow3.destroyOndehA) && (isOnPlateA())) {
            checkCoconutA();
            /*if (gameflow3.coconutOnA) {
              undercookedcoconut.destroyA = true;
              gameflow3.coconutOnA = false;
              }*/

            gameflow3.destroyOndehA = false;
            resetA();
            Destroy(gameObject);
        }
        if ((gameflow3.destroyOndehB) && (isOnPlateB())) {
            checkCoconutB();
            /*if (gameflow3.coconutOnB) {
              undercookedcoconut.destroyB = true;
              gameflow3.coconutOnB = false;
              }*/

            gameflow3.destroyOndehB = false;
            resetB();
            Destroy(gameObject);

        }

    }

    /* Supports:
    * (i) Adding coconut flakes to ondeh ondeh
    * (ii) Trashing mechanism
    */
    void OnMouseDown() {
        //adding coconut
        if ((gameflow3.coconutClicked) && (noCoconutOnPlate())) {
            Instantiate(undercookedCoconutObj, transform.position +
                    gameflow3.addUndercookedCoconutCoords, undercookedCoconutObj.rotation);
            addedCoconut();

            //reset
            gameflow3.ondehPlateAClicked = false;
            gameflow3.ondehPlateBClicked = false;

            //click plate
        } else if (isOnPlateA()) {
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

    /*Check if coconut flakes has been added to plate A. If it has, destroy coconut flakes too. Supports trashing mechanism
    */
    void checkCoconutA() {
        if (gameflow3.coconutOnA) {
            undercookedcoconut.destroyA = true;
            gameflow3.coconutOnA = false;
        }
    }
    /*Check if coconut flakes has been added to plate B. If it has, destroy coconut flakes too. Supports trashing mechanism
    */
    void checkCoconutB() {
        if (gameflow3.coconutOnB) {
            undercookedcoconut.destroyB = true;
            gameflow3.coconutOnB = false;
        }
    }

    /*Reset variables on plate A so that new ondeh ondeh can be moved there.
    */
    void resetA() {
        gameflow3.ondehOnPlateA = false;
        gameflow3.ondehOnACooked = false;
    }
    /*Reset variables on plate B so that new ondeh ondeh can be moved there.
    */
    void resetB() {
        gameflow3.ondehOnPlateB = false;
        gameflow3.ondehOnBCooked = false;
    }


    /*Indicate in gameflow3 that coconut has already been added. In order to:
     * (i) prevent repeated addition of coconut flakes
     * (ii) check if dish has been prepared correctly during serving mechanism
    */
    void addedCoconut() {
        if (isOnPlateA()) {
            gameflow3.coconutOnA = true;
        } else if (isOnPlateB()) {
            gameflow3.coconutOnB = true;
        }
    }

    /*Checks if coconut flakes has already been added to the ondeh ondeh
    */
    bool noCoconutOnPlate() {
        if (isOnPlateA()) {
            return !gameflow3.coconutOnA;
        } else { //isOnPlateB
            return !gameflow3.coconutOnB;
        }
    }

    bool isOnPlateA() {
        return transform.position == gameflow3.plateACoords + gameflow3.undercookedOndehCoords;
    }
    bool isOnPlateB() {
        return transform.position == gameflow3.plateBCoords + gameflow3.undercookedOndehCoords;
    }

}
