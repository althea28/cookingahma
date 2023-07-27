using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of ondeh ondeh dish. Supports:
 * (i) Cooking mechanism of ondeh ondeh in steamer 
 * (ii) Moving ondeh ondeh from steamer to plate
*/
public class ondehsteamer : MonoBehaviour
{
    public static bool startCookingA = false;
    public static float cookingTimeA = 0f;
    private static bool hasCookedA = false;
    private static bool hasBurntA = false;

    public static bool startCookingB = false;
    public static float cookingTimeB = 0f;
    private static bool hasCookedB = false;
    private static bool hasBurntB = false;

    public Transform cookedBoilingOndehObj;
    public Transform overcookedBoilingOndehObj;
    public Transform undercookedOndehObj;
    public Transform cookedOndehObj;
    public Transform burntOndehObj;


    // Start is called before the first frame update
    void Start()
    {
        startCookingA = false;
        cookingTimeA = 0f;
        hasCookedA = false;
        hasBurntA = false;

        startCookingB = false;
        cookingTimeB = 0f;
        hasCookedB = false;
        hasBurntB = false;

    }

    // Update is called once per frame
    /* Tracks time that ondeh ondeh has spent on steamer. Show changes when ondeh ondeh is cooked/burnt.
    */
    void Update()
    {        
        //update times
        if (startCookingA) {
            cookingTimeA += Time.deltaTime;
        }
        if (startCookingB) {
            cookingTimeB += Time.deltaTime;
        }
        
        //check if cooked or burnt
        if ((startCookingA) && (cookingTimeA >= gameflow3.timeForOndehToCook) && 
                (!hasCookedA) && (isSteamerA())) { //check if steamer A cooked
            hasCookedA = true;
            Instantiate(cookedBoilingOndehObj, gameflow3.steamerACoords + gameflow3.addBoilingOndehCoords, 
                cookedBoilingOndehObj.rotation);
        } 
        if ((startCookingA) && (cookingTimeA >= gameflow3.timeForOndehToBurn) && 
                (!hasBurntA) && (isSteamerA())) { //check if steamer A burnt
            hasBurntA = true;
            Instantiate(overcookedBoilingOndehObj, gameflow3.steamerACoords + gameflow3.addBoilingOndehCoords, 
                overcookedBoilingOndehObj.rotation);
            cookedboilingondeh.destroyA = true;
        }

        if ((startCookingB) && (cookingTimeB >= gameflow3.timeForOndehToCook) && 
                (!hasCookedB) && (isSteamerB())) { //check if steamer B cooked
            hasCookedB = true;
            Instantiate(cookedBoilingOndehObj, gameflow3.steamerBCoords + gameflow3.addBoilingOndehCoords, 
                cookedBoilingOndehObj.rotation);
        } 
        if ((startCookingB) && (cookingTimeB >= gameflow3.timeForOndehToBurn) && 
                (!hasBurntB) && (isSteamerB())) { //check if steamer B burnt
            hasBurntB = true;
            Instantiate(overcookedBoilingOndehObj, gameflow3.steamerBCoords + gameflow3.addBoilingOndehCoords, 
                overcookedBoilingOndehObj.rotation);
            cookedboilingondeh.destroyB = true;
        }

    }

    /* Moves ondeh ondeh from steamer to plate.
    */
    void OnMouseDown() {
        
        //move from steamer A to plate
        if ((startCookingA) && (isSteamerA()) && (canMoveToPlate())) {
            checkCookingA();
            /*if (hasBurntA) { //burnt
                overcookedboilingondeh.destroyA = true;
                Instantiate(burntOndehObj, getPlateCoords("burnt"), burntOndehObj.rotation);
            } else if (hasCookedA) { //cooked but not burnt
                //gameflow3.ondehOnACooked = true;

                cookedboilingondeh.destroyA = true;
                Instantiate(cookedOndehObj, getPlateCoords("cooked"), cookedOndehObj.rotation);
            } else { //undercooked
                Instantiate(undercookedOndehObj, getPlateCoords("undercooked"), undercookedOndehObj.rotation);
            }*/
            resetA();

        //move from steamerB to plate
        } else if ((startCookingB) && (isSteamerB()) && (canMoveToPlate())) {
            checkCookingB();
            /*if (hasBurntB) { //burnt
                overcookedboilingondeh.destroyB = true;
                Instantiate(burntOndehObj, getPlateCoords("burnt"), burntOndehObj.rotation);
            } else if (hasCookedB) { //cooked but not burnt
                //gameflow3.ondehOnBCooked = true;

                cookedboilingondeh.destroyB = true;
                Instantiate(cookedOndehObj, getPlateCoords("cooked"), cookedOndehObj.rotation);
            } else { //undercooked
                Instantiate(undercookedOndehObj, getPlateCoords("undercooked"), undercookedOndehObj.rotation);
            }*/
            resetB();
        }

        //reset
        gameflow3.resetClicks = true;

    }
    
    /* Checks if ondeh ondeh is raw/cooked/burnt. Instantiate the according model on the plate.
    */
    void checkCookingA() {
            if (hasBurntA) { //burnt
                overcookedboilingondeh.destroyA = true;
                Instantiate(burntOndehObj, getPlateCoords("burnt"), burntOndehObj.rotation);
            } else if (hasCookedA) { //cooked but not burnt
                //gameflow3.ondehOnACooked = true;

                cookedboilingondeh.destroyA = true;
                Instantiate(cookedOndehObj, getPlateCoords("cooked"), cookedOndehObj.rotation);
            } else { //undercooked
                Instantiate(undercookedOndehObj, getPlateCoords("undercooked"), undercookedOndehObj.rotation);
            }
    }
    void checkCookingB() {
            if (hasBurntB) { //burnt
                overcookedboilingondeh.destroyB = true;
                Instantiate(burntOndehObj, getPlateCoords("burnt"), burntOndehObj.rotation);
            } else if (hasCookedB) { //cooked but not burnt
                //gameflow3.ondehOnBCooked = true;

                cookedboilingondeh.destroyB = true;
                Instantiate(cookedOndehObj, getPlateCoords("cooked"), cookedOndehObj.rotation);
            } else { //undercooked
                Instantiate(undercookedOndehObj, getPlateCoords("undercooked"), undercookedOndehObj.rotation);
            }
    }


    /* Reset all variables and destroy steam on steamer A, so that new ondeh ondeh can be added there.
    */
    void resetA() {
        ondehsteam.destroyA = true;
        
        gameflow3.doughOnSteamerA = false;
        startCookingA = false;
        hasCookedA = false;
        hasBurntA = false;
        cookingTimeA = 0;
    }
    
    /* Reset all variables and destroy steam on steamer B, so that new ondeh ondeh can be added there.
    */
    void resetB() {
        ondehsteam.destroyB = true;
        
        gameflow3.doughOnSteamerB = false;
        startCookingB = false;
        hasCookedB = false;
        hasBurntB = false;
        cookingTimeB = 0;
    }

    /* Return coordinates for ondeh ondeh to be instantiated on plates.
     * @param status indicates which coordinates should be returned based on if ondeh ondeh is raw/cooked/burnt
     * @return coordinates where ondeh ondeh should be instantiated at.
    */
    Vector3 getPlateCoords(string status) {
        Vector3 coords = new Vector3(0,0,0);
        if (status == "burnt") {
            coords = gameflow3.overcookedOndehCoords;
        } else if (status == "cooked") {
            coords = gameflow3.cookedOndehCoords;
        } else { //undercooked
            coords = gameflow3.undercookedOndehCoords;
        }

        if (!gameflow3.ondehOnPlateA) {
            
            indicateCookedA(status);
            /*if (status == "cooked") {
                gameflow3.ondehOnACooked = true;
            }*/

            gameflow3.ondehOnPlateA = true;
            coords += gameflow3.plateACoords;
        } else if (!gameflow3.ondehOnPlateB) {

            indicateCookedB(status);
            /*if (status == "cooked") {
                gameflow3.ondehOnBCooked = true;
            }*/

            gameflow3.ondehOnPlateB = true;
            coords += gameflow3.plateBCoords;
        }
        return coords;
    }

    /*Indicate in gameflow3 that ondeh ondeh on plate A is cooked. 
     * Used again when checking if ondeh ondeh is cooked correctly during serving mechanism.
    */
    void indicateCookedA(string status) {
        if (status == "cooked") {
            gameflow3.ondehOnACooked = true;
        }
    }

    /*Indicate in gameflow3 that ondeh ondeh on plate B is cooked. 
     * Used again when checking if ondeh ondeh is cooked correctly during serving mechanism.
    */
    void indicateCookedB(string status) {
            if (status == "cooked") {
                gameflow3.ondehOnBCooked = true;
            }
    }
    
    /*Checks if there is space on the plates for ondeh ondeh to be moved to.
    */
    bool canMoveToPlate() {
        return !gameflow3.ondehOnPlateA || !gameflow3.ondehOnPlateB;
    }

    bool isSteamerA() {
        return transform.position == gameflow3.steamerACoords;
    }
    bool isSteamerB() {
        return transform.position == gameflow3.steamerBCoords;
    }

}
