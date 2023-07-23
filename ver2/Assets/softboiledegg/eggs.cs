using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggs : MonoBehaviour
{

    //time spent on steamer
    public static float eggCookingTimeA = 0;
    public static float eggCookingTimeB = 0;

    //ensures that only instantiate steam once
    public static bool isCookedA = false;     
    public static bool isCookedB = false;
    public static bool isBurntA = false;     
    public static bool isBurntB = false;

    //steam obj
    public Transform cookedEggSteamObj;
    public Transform burntEggSteamObj;

    //subsequent eggs for plating
    public Transform undercookedEggsObj;
    public Transform cookedEggsObj;
    public Transform overcookedEggsObj;

    //destroy cooksteamobj
    public static bool trigDestroyCookedSteamA = false;
    public static bool trigDestroyCookedSteamB = false;
    public static bool trigDestroyOvercookedSteamA = false;
    public static bool trigDestroyOvercookedSteamB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update how long eggs have been on steamer
        if (isOnSteamerA()) {
            eggCookingTimeA += Time.deltaTime;
        } else if (isOnSteamerB()) {
            eggCookingTimeB += Time.deltaTime;
        }

        //if egg is cooked, add cooked steam
        if ((eggCookingTimeA >= gameflow.timeForEggToCook) && (isOnSteamerA()) && (!isCookedA)) { 
            Instantiate(cookedEggSteamObj, newSteamCoords(), cookedEggSteamObj.rotation);
            isCookedA = true;

        } else if ((eggCookingTimeB >= gameflow.timeForEggToCook) && (isOnSteamerB()) && (!isCookedB)) {
            Instantiate(cookedEggSteamObj, newSteamCoords(), cookedEggSteamObj.rotation);
            isCookedB = true;
        }

        //if egg is burned, add burned steam
        if ((eggCookingTimeA >= gameflow.timeForEggToBurn) && (isOnSteamerA()) && (!isBurntA)) {
            //add burnt steam obj
            Instantiate(burntEggSteamObj, newSteamCoords(), burntEggSteamObj.rotation);
            isBurntA = true;

        } else if ((eggCookingTimeB >= gameflow.timeForEggToBurn) && (isOnSteamerB()) && (!isBurntB)) {
            //add burnt steam obj
            Instantiate(burntEggSteamObj, newSteamCoords(), burntEggSteamObj.rotation);
            isBurntB = true;
        }
        
    }

    void OnMouseDown() { //transfer to plate
        
        gameflow.resetClicks = true;

        if (((isOnSteamerA()) && emptySpaceOnPlates())) { //if is on A and can be moved

            movingA();
            /*if ((!isCookedA) && (!isBurntA)) { //if A is undercooked
                Instantiate(undercookedEggsObj, transferEggsCoords("undercooked"), undercookedEggsObj.rotation);
                
            } else if ((isCookedA) && (!isBurntA)) { //if A is cooked
                Instantiate(cookedEggsObj, transferEggsCoords("cooked"), cookedEggsObj.rotation);
                           
            } else if ((isCookedA) && (isBurntA)) { //if A is overcooked
                Instantiate(overcookedEggsObj, transferEggsCoords("overcooked"), overcookedEggsObj.rotation);
                           }*/
            resetA();
        } else if (((isOnSteamerB()) && emptySpaceOnPlates())) { //if is on B and can be moved
            
            movingB();
            /*if ((!isCookedB) && (!isBurntB)) { //if B is undercooked
                Instantiate(undercookedEggsObj, transferEggsCoords("undercooked"), undercookedEggsObj.rotation);
                
            } else if ((isCookedB) && (!isBurntB)) { //if B is cooked
                Instantiate(cookedEggsObj, transferEggsCoords("cooked"), cookedEggsObj.rotation);
                          
            } else if ((isCookedB) && (isBurntB)) { //if B is overcooked
                Instantiate(overcookedEggsObj, transferEggsCoords("overcooked"), overcookedEggsObj.rotation);
               
            }*/
            resetB();
        }


    }

    void movingA() {
        if ((!isCookedA) && (!isBurntA)) { //if A is undercooked
                Instantiate(undercookedEggsObj, transferEggsCoords("undercooked"), undercookedEggsObj.rotation);
                
        } else if ((isCookedA) && (!isBurntA)) { //if A is cooked
            Instantiate(cookedEggsObj, transferEggsCoords("cooked"), cookedEggsObj.rotation);
                           
        } else if ((isCookedA) && (isBurntA)) { //if A is overcooked
            Instantiate(overcookedEggsObj, transferEggsCoords("overcooked"), overcookedEggsObj.rotation);
        }
    }

    void movingB() {
        if ((!isCookedB) && (!isBurntB)) { //if B is undercooked
                Instantiate(undercookedEggsObj, transferEggsCoords("undercooked"), undercookedEggsObj.rotation);
                
        } else if ((isCookedB) && (!isBurntB)) { //if B is cooked
            Instantiate(cookedEggsObj, transferEggsCoords("cooked"), cookedEggsObj.rotation);
                          
        } else if ((isCookedB) && (isBurntB)) { //if B is overcooked
            Instantiate(overcookedEggsObj, transferEggsCoords("overcooked"), overcookedEggsObj.rotation);
               
        }
    }

    void resetA() { //to destroy steam, reset timer, cooking checks, destroy eggs
        //to trigger destroying steam
        if (isCookedA) {
            trigDestroyCookedSteamA = true; //reset to false in eggsteam
        }
        if (isBurntA) {
            trigDestroyOvercookedSteamA = true;  //reset to false in eggOCsteam
        }
        gameflow.eggOnSteamerA = false;
        isCookedA = false;
        isBurntA = false;
        Destroy (gameObject);
        eggCookingTimeA = 0;

    }

    void resetB() { //to destroy steam, reset timer, cooking checks, destroy eggs
        //to trigger destroying steam
        if (isCookedB) {
            trigDestroyCookedSteamB = true; //reset to false in eggsteam
        }
        if (isBurntB) {
            trigDestroyOvercookedSteamB = true; //reset to false in eggOCsteam
        }
        gameflow.eggOnSteamerB = false;
        isCookedB = false;
        isBurntB = false;
        Destroy (gameObject);
        eggCookingTimeB = 0;
    }
    
    //get new coords for egg transfer (no need to know where egg is rn)
    Vector3 transferEggsCoords(string cookCheck) {
        if (!gameflow.eggsOnPlateA) { //transf to plate A
            gameflow.eggsOnPlateA = true;

            cookCheckA(cookCheck);
            /*if (cookCheck == "cooked") {
                gameflow.plateACooked = true;
            }*/
            return gameflow.plateACoords + adjustEggCoords(cookCheck);
        } else { //transf to plate B
            gameflow.eggsOnPlateB = true;

            cookCheckB(cookCheck);
            /*if (cookCheck == "cooked") {
                gameflow.plateBCooked = true;
            }*/
            return gameflow.plateBCoords + adjustEggCoords(cookCheck);
        }
    }

    void cookCheckA(string cookCheck) {
        if (cookCheck == "cooked") {
            gameflow.plateACooked = true;
        }
    }
    void cookCheckB(string cookCheck) {
        if (cookCheck == "cooked") {
                gameflow.plateBCooked = true;
        }
    }
        
    
    //adjusts eggs coordinates
    Vector3 adjustEggCoords(string cookCheck) {
        if (cookCheck == "undercooked") {
            return gameflow.addUndercookedEggsCoords;
        } else if (cookCheck == "cooked") {
            return gameflow.addCookedEggsCoords;
        } else {
            return gameflow.addOvercookedEggsCoords;
        }
    }
        
    bool isOnSteamerA() {
        return transform.position == gameflow.steamerACoords;
    }

    bool isOnSteamerB() {
        return transform.position == gameflow.steamerBCoords;
    }

    Vector3 newSteamCoords() {
        return transform.position;
    }

    bool emptySpaceOnPlates() {
        if ((!gameflow.eggsOnPlateA) || (!gameflow.eggsOnPlateB)) {
            return true;
        } else {
            return false;
        }
    }

}
