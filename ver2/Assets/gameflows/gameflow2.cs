using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solution below adapted from https://www.youtube.com/playlist?list=PL4UezTfGBADBsdU4ytVRJRDq2RESjqffk

/* gameflow2 class is attached to GAMEMASTER object in levels 4 to 6
 * gameflow2 supports the serving of (i) chwee kueh and (ii) rojak. 
 * gameflow2 class:
 * (i) holds the coordinates for ingredients and dishes 
 * (ii) resets variables so that dishes can be repeatedly served
 * (iii) aids in interactions between different scripts
*/


public class gameflow2 : MonoBehaviour
{
    //sticky clicks:  chweekueh: plateAClicked, plateBClicked, chaiPohClicked
    //                rojak: knifeClicked, sauceClicked, boardAClicked, boardBClicked, bowlAClicked, BowlBClicked 

    //level stats
    public static int customersServed = 0;

    //num of dishes possible for this level
    //public static int numOfDishes = 1;

    //resetting clicks
    public static bool resetClicks = false; 
    public static bool resetClicksChweeKueh = false;
    public static bool resetClicksRojak = false;

    //customer generation
    public static string dishOnA = "none";
    public static string dishOnB = "none";
    public static string dishOnC = "none";

    //chwee kueh
    public static Vector3 steamerACoords = new Vector3(6.58f, 3.493f, 1.574f);
    public static Vector3 steamerBCoords = new Vector3(6.58f, 3.493f, 3.61f);
    public static Vector3 plateACoords = new Vector3(4.246f, 3.148f, 2.53f);
    public static Vector3 plateBCoords = new Vector3(4.246f, 3.148f, 3.96f);
    public static Vector3 cpSpoonCoords = new Vector3(1.194f, 3.784f, 1.07f);

    public static Vector3 addUndercookedCKCoords = new Vector3(0,0, -0.043f); //from plate coords
    public static Vector3 addCookedCKCoords = new Vector3(0.03f, 0.072f, 0.02f); //from plate coords
    public static Vector3 addOvercookedCKCoords = new Vector3(0.03f, 0.072f, 0.02f); //from plate coords

    public static Vector3 burntLayerCoords = new Vector3(0, -0.005f, 0); //from steamercoords
    public static Vector3 addUndercookedCP = new Vector3(-0.757f, -0.003f, -0.327f); //from undercooked CK
    public static Vector3 addCookedCP = new Vector3(0.006f, 0.108f, 0.006f); //from cooked CK
    public static Vector3 addOvercookedCP = new Vector3(0.006f, 0.108f, 0.006f); //from overcooked CK

    public static float timeForCkToCook = 3f;
    public static float timeForCkToBurn = 5f;

    public static bool ckOnSteamerA = false;
    public static bool ckOnSteamerB = false;

    public static bool ckOnPlateA = false;
    public static bool ckOnPlateB = false;

    public static bool plateACooked = false;
    public static bool plateBCooked = false;
    public static bool hasCPOnA = false;
    public static bool hasCPOnB = false;

    public static bool chaiPohClicked = false;
    public static bool plateAClicked = false;
    public static bool plateBClicked = false;

    public static bool serveCkA = false;
    public static bool serveCkB = false;

    public static bool trashPlateA = false;
    public static bool trashPlateB = false;

    public static bool destroySteamA = false;
    public static bool destroySteamB = false;

    public static bool trashA = false;
    public static bool trashB = false;

    //rojak
    public static bool foodOnBoardA = false;
    public static bool foodOnBoardB = false;

    public static bool knifeClicked = false;
    public static bool sauceClicked = false;
    public static bool boardAClicked = false;
    public static bool boardBClicked = false;

    public static int stepOnBowlA = 1;
    public static int stepOnBowlB = 1;

    public static int stepEmptyPlate = 1;
    public static int stepPlateWithFruit = 2;
    public static int stepPlateWithVege = 3;
    public static int stepPlateWithTofu = 4;
    public static int stepReadyPlate = 5;

    public static bool bowlAClicked = false;
    public static bool bowlBClicked = false;
    public static bool serveRojakA = false;
    public static bool serveRojakB = false;
    public static bool trashBoardA = false;
    public static bool trashBoardB = false;

    public static Vector3 addFruitsBoardCoords = new Vector3(0.43f, 0.246f, 0.09f); //from board
    public static Vector3 addCutFruitsBoardCoords = new Vector3(0.43f, 0.135f, 0.09f); //from board
    public static Vector3 addVegeBoardCoords = new Vector3(0.54f, 0.168f, -0.06f); //from board
    public static Vector3 addCutVegeBoardCoords = new Vector3(0.291f, 0.08f, 0.048f); //from board
    public static Vector3 addTofuBoardCoords = new Vector3 (0.45f, 0.12f, 0.12f); //from board
    public static Vector3 addCutTofuBoardCoords = new Vector3 (0.169f, -0.18f, 0.126f); //from board

    public static Vector3 boardACoords = new Vector3(-2.47f, 3.06f, 3.77f);
    public static Vector3 boardBCoords = new Vector3(-5.14f, 3.06f, 3.77f);
    public static Vector3 bowlACoords = new Vector3(2.01f, 2.95f, 3.41f);
    public static Vector3 bowlBCoords = new Vector3(-0.06f, 2.95f, 3.41f);


    //LEVEL INITIATE
    public static bool initiating = false;

    // Start is called before the first frame update
    /** Resets all variables when every level starts
    */
    void Start()
    {
        initiating = true;
        
        dishOnA = "none";
        dishOnB = "none";
        dishOnC = "none";

        //chweekueh
        destroySteamA = false;
        destroySteamB = false;

        trashA = false;
        trashB = false;
        
        ckOnSteamerA = false;
        ckOnSteamerB = false;
        ckOnPlateA = false;
        ckOnPlateB = false;

        plateACooked = false;
        plateBCooked = false;
        hasCPOnA = false;
        hasCPOnB = false;

        chaiPohClicked = false;
        plateAClicked = false;
        plateBClicked = false;

        serveCkA = false;
        serveCkB = false;

        trashPlateA = false;
        trashPlateB = false;
        destroySteamA = false;
        destroySteamB = false;
        trashA = false;
        trashB = false;

        chweekuehbatter.ckCookingTimeA = 0;
        chweekuehbatter.ckCookingTimeB = 0;
        chweekuehbatter.isCookedA = false;
        chweekuehbatter.isCookedB = false;
        chweekuehbatter.isBurntA = false;
        chweekuehbatter.isBurntB = false;

        //rojak
        foodOnBoardA = false;
        foodOnBoardB = false;

        knifeClicked = false;
        sauceClicked = false;
        boardAClicked = false;
        boardBClicked = false;

        stepOnBowlA = 1;
        stepOnBowlB = 1;

        bowlAClicked = false;
        bowlBClicked = false;
        serveRojakA = false;
        serveRojakB = false;
        trashBoardA = false;
        trashBoardB = false;


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
        } else if (resetClicksChweeKueh) {
            resetClickingChweeKueh();
        } else if (resetClicksRojak) {
            resetClickingRojak();
        }


    }

    
    /** Resets variables of sticky clicks for chwee kueh and rojak
    */
    public void resetClicking() {
        resetClickingChweeKueh();
        resetClickingRojak();

        resetClicks = false;
    }

    /** Resets variables of sticky clicks for chwee kueh
    */
    public void resetClickingChweeKueh() {
        plateAClicked = false;
        plateBClicked = false;
        chaiPohClicked = false;

        resetClicksChweeKueh = false;
    }

    /** Resets variables of sticky clicks for rojak
    */
    public void resetClickingRojak() {
        knifeClicked = false;
        sauceClicked = false;
        boardAClicked = false;
        boardBClicked = false;
        bowlAClicked = false;
        bowlBClicked = false;

        resetClicksRojak = false;
    }
    

}
