using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* Part of soft boiled eggs dish. Supports:
 * (i) Trashing and serving mechanism of this dish.
 * (ii) Adding soya sauce to this dish.
*/

public class rawEgg : MonoBehaviour
{

    public Transform soyaSauceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys object when player is trying to trash or after serving this dish.
    */
    void Update()
    {
        //trying to trash OR serve => destroy obj
        if (((gameflow.trashPlateA) && (isOnPlateA())) || (((gameflow.serveEggA) && (isOnPlateA()))))  {
            
            checkSoyaA();
            /*if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
                soyasauce.trashSoyaA = true;
            }*/

            gameflow.trashPlateA = false;
            gameflow.serveEggA = false;

            resetA();
            Destroy (gameObject);

        } else if (((gameflow.trashPlateB) && (isOnPlateB())) || ((gameflow.serveEggB) && (isOnPlateB()))) {

            checkSoyaB();
            /*if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
                soyasauce.trashSoyaB = true;
            }*/

            gameflow.trashPlateB = false;
            gameflow.serveEggB = false;

            resetB();
            Destroy (gameObject);
        }
            
        
    }

    /* Supports:
     * (i) Trashing and serving mechanism of dish
     * (ii) Adding soya sauce to this dish
    */
    void OnMouseDown() {
        if ((gameflow.soyaSauceClicked) && (canAddSoyaSauce())) {
            //add soya sauce to egg
            Instantiate(soyaSauceObj, transform.position + gameflow.addSoyaSauceCoords, soyaSauceObj.rotation);
            addedSoya(); //indicate in gameflow that added soya sauce
            
            //RESET===
            gameflow.resetClicksEggs = true;

        } else if (isOnPlateA()) {
            gameflow.plateAClicked = true;

            //RESET===
            gameflow.plateBClicked = false;

        } else if (isOnPlateB()) {
            gameflow.plateBClicked = true;

            //RESET===
            gameflow.plateAClicked = false;

        }
        gameflow.soyaSauceClicked = false;
        gameflow.resetClicksToast = true;

    }

    /* Supports trashing mechanism. Checks if soya sauce has been added to plate A. If it has, destroy it.
    */
    void checkSoyaA() {
        if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
            soyasauce.trashSoyaA = true;
        }
    }

    /* Supports trashing mechanism. Checks if soya sauce has been added to plate B. If it has, destroy it.
    */
    void checkSoyaB() {
        if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
            soyasauce.trashSoyaB = true;
        }
    }
    
    /* Checks if soya sauce can be added to this egg, i.e. soya sauce has not been added before
    */
    bool canAddSoyaSauce() {
        if (isOnPlateA()) {
            return (!gameflow.hasSoyaOnA);
        } else { //is on plate B
            return (!gameflow.hasSoyaOnB);
        }
    }

    /* Reset variables of plate A, so new eggs can be moved there.
    */
    void resetA() { //to reset added soya, is on plate A
        gameflow.hasSoyaOnA = false;
        gameflow.eggsOnPlateA = false;
        gameflow.plateACooked = false;
    }

    /* Reset variables of plate B, so new eggs can be moved there.
    */
    void resetB() { //to reset added soya, is on plate A
        gameflow.hasSoyaOnB = false;
        gameflow.eggsOnPlateB = false;
        gameflow.plateBCooked = false;

    }

    /* Indicate in gameflow if soya sauce has been added to the plate. Will be used in serving and trashing mechanism later on.
    */
    void addedSoya() {
        if (isOnPlateA()) {
            gameflow.hasSoyaOnA = true;
        } else if (isOnPlateB()) {
            gameflow.hasSoyaOnB = true;
        }
    }

    bool isOnPlateA() {
        return transform.position == gameflow.plateACoords + gameflow.addUndercookedEggsCoords;
    }

    bool isOnPlateB() {
        return transform.position == gameflow.plateBCoords + gameflow.addUndercookedEggsCoords;
    }

}
