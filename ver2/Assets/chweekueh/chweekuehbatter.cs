using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/* Part of chweekueh dish. Supports:
 * (i) Cooking mechanism of chwee kueh batter
 * (ii) Moving chwee kueh batter from steamer to plate
*/
public class chweekuehbatter : MonoBehaviour
{
    //time spent on steamer
    public static float ckCookingTimeA = 0;
    public static float ckCookingTimeB = 0;

    //ensures that only instantiate steam once
    public static bool isCookedA = false;     
    public static bool isCookedB = false;
    public static bool isBurntA = false;
    public static bool isBurntB = false;

    //steam obj
    public Transform SteamObj;

    //burnt CK;
    public Transform burntLayerObj;

    //subsequent ck for plating
    public Transform undercookedCkObj;
    public Transform cookedCkObj;
    public Transform overcookedCkObj;

 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /* Manages cooking mechanism of chwee kueh. Tracks time spent on steamer and show visual feedback when it is cooked or burnt.
    */
    void Update()
    {
        //update how long ck have been on steamer
        if (isOnSteamerA()) {
            ckCookingTimeA += Time.deltaTime;
        } else if (isOnSteamerB()) {
            ckCookingTimeB += Time.deltaTime;
        }

        //if ck is cooked, add steam
        if ((ckCookingTimeA >= gameflow2.timeForCkToCook) && (isOnSteamerA()) && (!isCookedA)) { 
            Instantiate(SteamObj, newSteamCoords(), SteamObj.rotation);
            isCookedA = true;

        } else if ((ckCookingTimeB >= gameflow2.timeForCkToCook) && (isOnSteamerB()) && (!isCookedB)) {
            Instantiate(SteamObj, newSteamCoords(), SteamObj.rotation);
            isCookedB = true;
        }

        //if egg is burned, 
        if ((ckCookingTimeA >= gameflow2.timeForCkToBurn) && (isOnSteamerA()) && (!isBurntA)) {
            Instantiate(burntLayerObj,transform.position + gameflow2.burntLayerCoords, burntLayerObj.rotation);
            isBurntA = true;

        } else if ((ckCookingTimeB >= gameflow2.timeForCkToBurn) && (isOnSteamerB()) && (!isBurntB)) {
            Instantiate(burntLayerObj,transform.position + gameflow2.burntLayerCoords, burntLayerObj.rotation);
            isBurntB = true;
        }
    }
    
    /* Moves chwee kueh from steamer to plate, if there is space on the plates.
    */
    void OnMouseDown() {
        gameflow2.resetClicks = true;

        if (((isOnSteamerA()) && emptySpaceOnPlates())) { //if is on A and can be moved
            if ((!isCookedA) && (!isBurntA)) { //if A is undercooked
                Instantiate(undercookedCkObj, transferCkCoords("undercooked"), undercookedCkObj.rotation);
                
            } else if ((isCookedA) && (!isBurntA)) { //if A is cooked
                Instantiate(cookedCkObj, transferCkCoords("cooked"), cookedCkObj.rotation);
                           
            } else if ((isCookedA) && (isBurntA)) { //if A is overcooked
                Instantiate(overcookedCkObj, transferCkCoords("overcooked"), overcookedCkObj.rotation);
            }
            resetA();
        } else if (((isOnSteamerB()) && emptySpaceOnPlates())) { //if is on B and can be moved
            if ((!isCookedB) && (!isBurntB)) { //if B is undercooked
                Instantiate(undercookedCkObj, transferCkCoords("undercooked"), undercookedCkObj.rotation);
                
            } else if ((isCookedB) && (!isBurntB)) { //if B is cooked
                Instantiate(cookedCkObj, transferCkCoords("cooked"), cookedCkObj.rotation);
                          
            } else if ((isCookedB) && (isBurntB)) { //if B is overcooked
                Instantiate(overcookedCkObj, transferCkCoords("overcooked"), overcookedCkObj.rotation);
               
            }
            resetB();
        }

    }
    
    /* Resets variables and destroy steam of position A of steamer, so new chwee kueh can be instantiated there.
    */
    void resetA() { //to destroy steam, reset timer, cooking checks, destroy ck
        //to trigger destroying steam
        if (isCookedA) {
            gameflow2.destroySteamA = true;
        }
        if (isBurntA) {
            burntLayer.destroyA = true;
        }
        gameflow2.ckOnSteamerA = false;
        isCookedA = false;
        isBurntA = false;
        Destroy (gameObject);
        ckCookingTimeA = 0; 

    }

    /* Resets variables and destroy steam of position B of steamer, so new chwee kueh can be instantiated there.
    */
    void resetB() { //to destroy steam, reset timer, cooking checks, destroy ck
        //to trigger destroying steam
        if (isCookedB) {
            gameflow2.destroySteamB = true;  
        }
        if (isBurntB) {
            burntLayer.destroyB = true;
        }
        gameflow2.ckOnSteamerB = false;
        isCookedB = false;
        isBurntB = false;
        Destroy (gameObject);
        ckCookingTimeB = 0; 

    }

    //get new coords for egg transfer (no need to know where egg is rn)
    /* Get plate coordinates to instantied chwee kueh on plates.
     * @param cookCheck to signal whether to return raw/cooked/burnt chwee kueh coordinates
     * @return appropriate coordinates to instantiate chwee kueh at when moving from steamer to plates
    */
    Vector3 transferCkCoords(string cookCheck) {
        if (!gameflow2.ckOnPlateA) { //transf to plate A
            gameflow2.ckOnPlateA = true;
            if (cookCheck == "cooked") {
                gameflow2.plateACooked = true;
            }
            return gameflow2.plateACoords + adjustCkCoords(cookCheck);
        } else { //transf to plate B
            gameflow2.ckOnPlateB = true;
            if (cookCheck == "cooked") {
                gameflow2.plateBCooked = true;
            }
            return gameflow2.plateBCoords + adjustCkCoords(cookCheck);
        }
    }

    //adjusts ck coordinates
    /* Returns appropriate model coordinates to instantiate chwee kueh on plates.
     * @param cookCheck to signal whether to return raw/cooked/burnt chwee kueh coordinates
     * @return appropriate coordinates to instantiate chwee kueh at when moving from steamer to plates
     */
    Vector3 adjustCkCoords(string cookCheck) {
        if (cookCheck == "undercooked") {
            return gameflow2.addUndercookedCKCoords;
        } else if (cookCheck == "cooked") {
            return gameflow2.addCookedCKCoords;
        } else {
            return gameflow2.addOvercookedCKCoords;
        }
    }

    bool isOnSteamerA() {
        return transform.position == gameflow2.steamerACoords;
    }

    bool isOnSteamerB() {
        return transform.position == gameflow2.steamerBCoords;
    }

    Vector3 newSteamCoords() {
        return transform.position;
    }
    /* Checks whether there is space on the plates to move the chwee kueh to.
    */
    bool emptySpaceOnPlates() {
        if ((!gameflow2.ckOnPlateA) || (!gameflow2.ckOnPlateB)) {
            return true;
        } else {
            return false;
        }
    }

}
