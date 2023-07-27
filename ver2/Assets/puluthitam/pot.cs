using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk
/*Part of pulut hitam dish. Supports:
 * (i) cooking mechanism of dish
 * (ii) Moving pulut hitam from pot to bowl
*/
public class pot : MonoBehaviour
{
    public Transform cookedCookingPulutObj;
    public Transform burntCookingPulutObj;

    public Transform rawPulutObj;
    public Transform cookedPulutObj;
    public Transform burntPulutObj;

    private int stepToStartCooking = 3;

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
    /*Tracks time pulut hitam spends in the pot. Shows changes according to if it is cooked/burnt
    */
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

            cookedCookingPulut.destroyA = true;
            Instantiate(burntCookingPulutObj, gameflow3.potACoords + gameflow3.addRiceCoords, burntCookingPulutObj.rotation);
            hasBurnedA = true;

        } else if ((cookingTimeA >= gameflow3.timeForPulutToCook) && (!hasCookedA) && (isPotA())) {

            rawCookingPulut.destroyA = true;
            sugarPieces.destroyA = true;

            Instantiate(cookedCookingPulutObj, gameflow3.potACoords + gameflow3.addRiceCoords, cookedCookingPulutObj.rotation);
            hasCookedA = true;
        }

        //check if B is cooked/burnt
        if ((cookingTimeB >= gameflow3.timeForPulutToBurn) && (!hasBurnedB) && (isPotB())) {

            cookedCookingPulut.destroyB = true;
            Instantiate(burntCookingPulutObj, gameflow3.potBCoords + gameflow3.addRiceCoords, burntCookingPulutObj.rotation);
            hasBurnedB = true;

        } else if ((cookingTimeB >= gameflow3.timeForPulutToCook) && (!hasCookedB) && (isPotB())) {

            rawCookingPulut.destroyB = true;
            sugarPieces.destroyB = true;

            Instantiate(cookedCookingPulutObj, gameflow3.potBCoords + gameflow3.addRiceCoords, cookedCookingPulutObj.rotation);
            hasCookedB = true;
        }

    }
    
    /* Supports moving pulut hitam from pot to bowl
    */
    void OnMouseDown() {
        if ((isPotA()) && (canMoveToBowl()) && (gameflow3.potAStep > stepToStartCooking)) {

            //Check if dish is raw/cooked/burnt, then instantiates correct model on bowl
            checkCookingA();     

            //Resets all variables so that new dish can be cooked on pot
            resetA();

        } else if ((isPotB()) && (canMoveToBowl()) && (gameflow3.potBStep > stepToStartCooking)) {

            //Check if dish is raw/cooked/burnt, then instantiates correct model on bowl
            checkCookingB();

            //Resets all variables so that new dish can be cooked on pot
            resetB();
        }
        //reset
        gameflow3.resetClicks = true;
    }
    
    /*Checks if pulut hitam in pot A is raw/cooked/burnt and instantiate models in bowls accordingly
    */
    void checkCookingA() {
        if (hasBurnedA) { //if dish is burnt
            burntCookingPulut.destroyA = true;
            Instantiate(burntPulutObj, getBowlCoords() + gameflow3.addPulutCoords, burntPulutObj.rotation);

        } else if (hasCookedA) { //if dish is cooked
            indicateCooked();

            cookedCookingPulut.destroyA = true;
            Instantiate(cookedPulutObj, getBowlCoords() + gameflow3.addPulutCoords, cookedPulutObj.rotation);

        } else { //if dish is raw
            sugarPieces.destroyA = true;

            rawCookingPulut.destroyA = true;
            Instantiate(rawPulutObj, getBowlCoords() + gameflow3.addPulutCoords, rawPulutObj.rotation);
        }
    }
    /*Checks if pulut hitam in pot B is raw/cooked/burnt and instantiate models in bowls accordingly
    */
    void checkCookingB() {
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
    }

    /*Resets variables and destroy items in pot A so that new pulut hitam can be cooked here.
    */
    void resetA() {
        gameflow3.potAStep = 1;
        isCookingA = false;
        cookingTimeA = 0f;
        hasCookedA = false;
        hasBurnedA = false;

        pandanLeaf.destroyA = true;
        pulutSteam.destroyA = true;
    }
    
    /*Resets variables and destroy items in pot B so that new pulut hitam can be cooked here.
    */
    void resetB() {
        gameflow3.potBStep = 1;
        isCookingB = false;
        cookingTimeB = 0f;
        hasCookedB = false;
        hasBurnedB = false;

        pandanLeaf.destroyB = true;
        pulutSteam.destroyB = true;

    }

    /*Get coordinates of bowl where pulut hitam should be instantiated
    */
    Vector3 getBowlCoords() {
        if (!gameflow3.bowlAOccupied) {
            gameflow3.bowlAOccupied = true;
            return gameflow3.bowlACoords;
        } else { //if bowl B not occupied
            gameflow3.bowlBOccupied = true;
            return gameflow3.bowlBCoords;
        }
    }
    
    /*If pulut hitam is cooked, indicate in gameflow3. 
    * Used again during serving mechanism to check if dish is prepared correctly.
    */
    void indicateCooked() {
        if (!gameflow3.bowlAOccupied) {
            gameflow3.bowlACooked = true;
        } else { //if moving to bowl b
            gameflow3.bowlBCooked = true;
        }
    }
    
    /*Check if there is space in bowls to move pulut hitam to
    */
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
