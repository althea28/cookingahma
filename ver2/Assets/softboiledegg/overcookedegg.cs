using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* Part of soft boiled eggs dish. Supports:
 * (i) Trashing mechanism of this dish.
 * (ii) Adding soya sauce to this dish.
*/
public class overcookedegg : MonoBehaviour
{

    public Transform ocSoyaSauceObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Destroys object when player is trying to trash this dish.
    */
    void Update()
    {
        if ((gameflow.trashPlateA) && (isOnPlateA())) {
            
            checkSoyaA();
            /*if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
                ocSoyasauce.trashSoyaA = true;
            }*/

            gameflow.trashPlateA = false;
            resetA();
            Destroy (gameObject);
        } else if ((gameflow.trashPlateB) && (isOnPlateB())) {

            checkSoyaB();
            /*if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
                ocSoyasauce.trashSoyaB = true;
            }*/
            gameflow.trashPlateB = false;
            resetB();
            Destroy (gameObject);
        }
        
    }
    
    /* Supports:
     * (i) Trashing mechanism of dish
     * (ii) Adding soya sauce to this dish
    */
    void OnMouseDown() {
        if ((gameflow.soyaSauceClicked) && (canAddSoyaSauce())) {
            Instantiate(ocSoyaSauceObj, 
                transform.position + gameflow.addOCSoyaSauceCoords, ocSoyaSauceObj.rotation);
            addedSoya(); //indicate in gameflow that added soya sauce
            gameflow.soyaSauceClicked = false;

            //RESET===
            gameflow.resetClicks = true; 

        } else if (isOnPlateA()) {
            gameflow.plateAClicked = true;

            //RESET===
            gameflow.resetClicksToast = true;
            gameflow.plateBClicked = false;

        } else if (isOnPlateB()) {
            gameflow.plateBClicked = true;
            
            //RESET===
            gameflow.resetClicksToast = true;
            gameflow.plateAClicked = false;

        }
    }
    
    /* Supports trashing mechanism. Checks if soya sauce has been added to plate A. If it has, destroy it.
    */
    void checkSoyaA() {
        if (gameflow.hasSoyaOnA) { //if added soya to A, destroy it too.
            ocSoyasauce.trashSoyaA = true;
        }
    }
    
    /* Supports trashing mechanism. Checks if soya sauce has been added to plate B. If it has, destroy it.
    */
    void checkSoyaB() {
        if (gameflow.hasSoyaOnB) { //if added soya to B, destroy it too
            ocSoyasauce.trashSoyaB = true;
        }
    }

    /* Reset variables of plate A, so new eggs can be moved there.
    */
    void resetA() {
        gameflow.hasSoyaOnA = false;
        gameflow.eggsOnPlateA = false;
        //gameflow.plateACooked = false;
    }

    /* Reset variables of plate B, so new eggs can be moved there.
    */
    void resetB() {
        gameflow.hasSoyaOnB = false;
        gameflow.eggsOnPlateB = false;
        //gameflow.plateBCooked = false;

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
        return transform.position == gameflow.plateACoords + gameflow.addOvercookedEggsCoords;
    }
    bool isOnPlateB() {
        return transform.position == gameflow.plateBCoords + gameflow.addOvercookedEggsCoords;
    }




}
