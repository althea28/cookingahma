using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* gameflow class is attached to GAMEMASTER object in levels 1 to 3
 * gameflow supports the serving of (i) kaya butter toast and (ii) soft-boiled egg. 
 * gameflow class:
 * (i) holds the coordinates for ingredients and dishes 
 * (ii) resets variables so that dishes can be repeatedly served
 * (iii) aids in interactions between different scripts
*/

public class gameflow : MonoBehaviour
{

    //sticky clicks: 
    //     kayatoast: placeKaya, placeButter, toastAIsClicked, toastBIsClicked
    //     eggs: plateAClicked, plateBClicked, soyaSauceClicked

    public static int customersServed = 0;
    //public static int numOfDishes = 2;

    public static bool resetClicks = false;
    public static bool resetClicksToast = false;
    public static bool resetClicksEggs = false;

    //kaya butter toast
    public static Vector3 boardACoordinates = new Vector3(0.93f,3.08f,3.37f);
    public static Vector3 boardBCoordinates = new Vector3(-0.93f,3.08f,3.37f);
    public static Vector3 grillACoordinates = new Vector3(-3.72f, 3.072f, 3.3f);
    public static Vector3 grillBCoordinates = new Vector3(-5.63f, 3.072f, 3.3f);
    public static Vector3 addKayaCoordinates = new Vector3(0.01f, 0.182f, 0.032f);
    public static Vector3 addButterCoordinates = new Vector3(0.005f, 0.247f, 0.129f);

    public static bool toastOnGrillA = false;
    public static bool toastOnGrillB = false;
    public static bool toastOnBoardA = false;
    public static bool toastOnBoardB = false;
    
    public static bool placeKaya = false; 
    public static bool placeButter = false;

    public static bool destroySteamA = false;
    public static bool destroySteamB = false;
    
    public static bool toastAIsClicked = false;
    public static bool toastBIsClicked = false;
    public static bool trashA = false;
    public static bool trashB = false;

    //soft boiled egg 
    public static Vector3 steamerACoords = new Vector3(6.044f, 3.385f, 3.55f);
    public static Vector3 steamerBCoords = new Vector3(5.11f, 3.385f, 3.55f); //5.047
    public static Vector3 plateACoords = new Vector3(3.36f, 3.01f, 1.916f);
    public static Vector3 plateBCoords = new Vector3(3.36f, 3.01f, 3.8f);

    public static Vector3 addUndercookedEggsCoords = new Vector3(-0.03f, -0.02f, 0.07f);
    public static Vector3 addCookedEggsCoords = new Vector3(-0.03f, -0.02f, 0.07f);
    public static Vector3 addOvercookedEggsCoords = new Vector3(0.05f, -0.02f, -0.04f);
    public static Vector3 addSoyaSauceCoords = new Vector3(-0.021f, 0.139f, -0.019f); //from egg, not plate
    public static Vector3 addOCSoyaSauceCoords = new Vector3(-0.11f, 0.15f, 0.19f);


    public static float timeForEggToCook = 3f;
    public static float timeForEggToBurn = 5f;

    public static bool eggOnSteamerA = false;
    public static bool eggOnSteamerB = false;

    public static bool eggsOnPlateA = false;
    public static bool eggsOnPlateB = false;

    public static bool plateACooked = false;
    public static bool plateBCooked = false;
    public static bool hasSoyaOnA = false;
    public static bool hasSoyaOnB = false;

    public static bool soyaSauceClicked = false;
    public static bool plateAClicked = false;
    public static bool plateBClicked = false;

    public static bool serveEggA = false;
    public static bool serveEggB = false;

    public static bool trashPlateA = false;
    public static bool trashPlateB = false;


    //customers
    public static string dishOnA = "none";
    public static string dishOnB = "none";
    public static string dishOnC = "none";
    public static int count = 0;

    //LEVEL INITIATE
    public static bool initiating = false;

    public static int sceneCounter = 0;

    // Start is called before the first frame update
    /** Resets all variables when every level starts
    */
    void Start()
    {
        initiating = true; //INITIATES LEVEL DETAILS
        
        //toast
        toastOnGrillA = false;
        toastOnGrillB = false;
        toastOnBoardA = false;
        toastOnBoardB = false;

        placeKaya = false;
        placeButter = false;

        destroySteamA = false;
        destroySteamB = false;

        toastAIsClicked = false;
        toastBIsClicked = false;
        trashA = false;
        trashB = false;

        toastInner.changedToCookedA = false;
        toastInner.changedToCookedB = false;
        toastInner.changedToBurntA = false;
        toastInner.changedToBurntB = false;

        toastclick.hasKayaOnA = false;
        toastclick.hasKayaOnB = false;
        toastclick.hasButterOnA = false;
        toastclick.hasButterOnB = false;

        toastclick.cookingTimeA = 0;
        toastclick.cookingTimeB = 0;
        toastclick.toastAIsCooked = false;
        toastclick.toastBIsCooked = false;
        toastclick.toastAIsBurnt = false;
        toastclick.toastBIsBurnt = false;

        toastclick.toastOnBoardAIsCooked = false;
        toastclick.toastOnBoardBIsCooked = false;
        toastclick.isToastAReady = false;
        toastclick.isToastBReady = false;
        toastclick.serveToastA = false;
        toastclick.serveToastB = false;

        //egg
        eggOnSteamerA = false;
        eggOnSteamerB = false;
        eggsOnPlateA = false;
        eggsOnPlateB = false;

        plateACooked = false;
        plateBCooked = false;
        hasSoyaOnA = false;
        hasSoyaOnB = false;

        soyaSauceClicked = false;
        plateAClicked = false;
        plateBClicked = false;

        serveEggA = false;
        serveEggB = false;
        trashPlateA = false;
        trashPlateB = false;

        eggs.eggCookingTimeA = 0;
        eggs.eggCookingTimeB = 0;

        eggs.isCookedA = false;
        eggs.isCookedB = false;
        eggs.isBurntA = false;
        eggs.isBurntB = false;

        dishOnA = "none";
        dishOnB = "none";
        dishOnC = "none";
        
        resetClicking();
        
    }

    // Update is called once per frame
    /** Resets variables for each dish
    */
    void Update()
    {
        Debug.Log("Scene counter " + gameflow.sceneCounter);
        if (resetClicks) {
            resetClicking();
        } else if (resetClicksToast) {
            resetClickingToast();
        } else if (resetClicksEggs) {
            resetClickingEggs();
        }
        
    }

    public Vector3 butterACoordinates() {
        return (boardACoordinates + addButterCoordinates);
    }

    public Vector3 butterBCoordinates() {
        return (boardBCoordinates + addButterCoordinates);
    }

    public Vector3 kayaACoordinates() {
        return (boardACoordinates + addKayaCoordinates);
    }

    public Vector3 kayaBCoordinates() {
        return (boardBCoordinates + addKayaCoordinates);
    }
    
    /** Resets variables of sticky clicks for kaya butter toast and soft boiled egg dish
    */
    public void resetClicking() {
        resetClickingToast();
        resetClickingEggs();

        resetClicks = false;
    }

    /** Resets variables of sticky clicks for kaya butter toast dish
    */
    public void resetClickingToast() {
        placeKaya = false; 
        placeButter = false;
        toastAIsClicked = false;
        toastBIsClicked = false;

        resetClicksToast = false;
    }

 
    /** Resets variables of sticky clicks for soft boiled egg
    */
    public void resetClickingEggs() {
        plateAClicked = false;
        plateBClicked = false;
        soyaSauceClicked = false;

        resetClicksEggs = false;
    }


 
}
