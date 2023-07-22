using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pot : MonoBehaviour
{
    public Transform cookedCookingPulutObj;
    public Transform burntCookingPulutObj;

    public Transform rawPulutObj;
    public Transform cookedPulutObj;
    public Transform burntPulutObj;

    public static bool isCookingA = false;
    public static bool isCookingB = false;

    private static float cookingTimeA = 0f;
    private static float cookingTimeB = 0f;

    private static bool hasCookedA = false;
    private static bool hasBurnedA = false;
    
    private static bool hasCookedB = false;
    private static bool hasBurnedB = false;

    // Start is called before the first frame update
    void Start()
    {
       isCookingA = false; 
       isCookingB = false;
       cookingTimeA = 0f;
       cookingTimeB = 0f;
       hasCookedA = false;
       hasBurnedA = false;
       hasCookedB = false;
       hasBurnedB = false;

    }

    // Update is called once per frame
    void Update()
    {
        //update cooking times
        if (isCookingA) {
            cookingTimeA += Time.deltaTime;
        }
        if (isCookingB) {
            cookingTimeB += Time.deltaTime;
        }
        
        //check if A is cooked/burnt
        if ((cookingTimeA >= gameflow3.timeForPulutToBurn) && (!hasBurnedA) && (isPotA())) {
            Debug.Log("a burnt");
            cookedCookingPulut.destroyA = true;
            Instantiate(burntCookingPulutObj, gameflow3.potACoords + gameflow3.addRiceCoords, burntCookingPulutObj.rotation);
            hasBurnedA = true;

        } else if ((cookingTimeA >= gameflow3.timeForPulutToCook) && (!hasCookedA) && (isPotA())) {
            Debug.Log("a cooked");

            rawCookingPulut.destroyA = true;
            sugarPieces.destroyA = true;

            Instantiate(cookedCookingPulutObj, gameflow3.potACoords + gameflow3.addRiceCoords, cookedCookingPulutObj.rotation);
            hasCookedA = true;
        }

        //check if B is cooked/burnt
        if ((cookingTimeB >= gameflow3.timeForPulutToBurn) && (!hasBurnedB) && (isPotB())) {
            Debug.Log("b burnt");

            cookedCookingPulut.destroyB = true;
            Instantiate(burntCookingPulutObj, gameflow3.potBCoords + gameflow3.addRiceCoords, burntCookingPulutObj.rotation);
            hasBurnedB = true;

        } else if ((cookingTimeB >= gameflow3.timeForPulutToCook) && (!hasCookedB) && (isPotB())) {
            Debug.Log("b cooked");

            rawCookingPulut.destroyB = true;
            sugarPieces.destroyB = true;

            Instantiate(cookedCookingPulutObj, gameflow3.potBCoords + gameflow3.addRiceCoords, cookedCookingPulutObj.rotation);
            hasCookedB = true;
        }
        
    }

    void OnMouseDown() {
        if ((isPotA()) && (canMoveToBowl()) && (gameflow3.potAStep > 3)) {
            if (hasBurnedA) {
                burntCookingPulut.destroyA = true;
                Instantiate(burntPulutObj, getBowlCoords() + gameflow3.addPulutCoords, burntPulutObj.rotation);
            } else if (hasCookedA) {
                indicateCooked();

                cookedCookingPulut.destroyA = true;
                Instantiate(cookedPulutObj, getBowlCoords() + gameflow3.addPulutCoords, cookedPulutObj.rotation);
            } else { //if raw
                sugarPieces.destroyA = true;

                rawCookingPulut.destroyA = true;
                Instantiate(rawPulutObj, getBowlCoords() + gameflow3.addPulutCoords, rawPulutObj.rotation);
            }
            resetA();
        } else if ((isPotB()) && (canMoveToBowl()) && (gameflow3.potBStep > 3)) {
            if (hasBurnedB) {
                burntCookingPulut.destroyB = true;
                Instantiate(burntPulutObj, getBowlCoords() + gameflow3.addPulutCoords, burntPulutObj.rotation);
            } else if (hasCookedB) {
                indicateCooked();

                cookedCookingPulut.destroyB = true;
                Instantiate(cookedPulutObj, getBowlCoords() + gameflow3.addPulutCoords, cookedPulutObj.rotation);
            } else { //if raw
                sugarPieces.destroyB = true;

                rawCookingPulut.destroyB = true;
                Instantiate(rawPulutObj, getBowlCoords() + gameflow3.addPulutCoords, rawPulutObj.rotation);
            }
            resetB();
        }

        //reset
        gameflow3.resetClicks = true;

    }
                
    void resetA() {
        gameflow3.potAStep = 1;
        isCookingA = false;
        cookingTimeA = 0f;
        hasCookedA = false;
        hasBurnedA = false;

        pandanLeaf.destroyA = true;
        pulutSteam.destroyA = true;
    }
    void resetB() {
        gameflow3.potBStep = 1;
        isCookingB = false;
        cookingTimeB = 0f;
        hasCookedB = false;
        hasBurnedB = false;

        pandanLeaf.destroyB = true;
        pulutSteam.destroyB = true;

    }

    
    Vector3 getBowlCoords() {
        if (!gameflow3.bowlAOccupied) {
            gameflow3.bowlAOccupied = true;
            return gameflow3.bowlACoords;
        } else { //if bowl B not occupied
            gameflow3.bowlBOccupied = true;
            return gameflow3.bowlBCoords;
        }
    }

    void indicateCooked() {
        if (!gameflow3.bowlAOccupied) {
            gameflow3.bowlACooked = true;
        } else { //if moving to bowl b
            gameflow3.bowlBCooked = true;
        }
    }

    bool canMoveToBowl() {
        return !gameflow3.bowlAOccupied || !gameflow3.bowlBOccupied;
    }

    bool isPotA() {
        return transform.position == gameflow3.potACoords;
    } 
    bool isPotB() {
        return transform.position == gameflow3.potBCoords;
    } 


}
