using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    void resetA() { //to destroy steam, reset timer, cooking checks, destroy ck
        //to trigger destroying steam
        if (isCookedA) {
            gameflow2.destroySteamA = "y"; 
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

    void resetB() { //to destroy steam, reset timer, cooking checks, destroy ck
        //to trigger destroying steam
        if (isCookedB) {
            gameflow2.destroySteamB = "y";  
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

    bool emptySpaceOnPlates() {
        if ((!gameflow2.ckOnPlateA) || (!gameflow2.ckOnPlateB)) {
            return true;
        } else {
            return false;
        }
    }

}
