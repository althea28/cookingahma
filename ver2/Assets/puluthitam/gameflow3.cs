using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow3 : MonoBehaviour
{
    //sticky clicks:  ondeh: coconutClicked, ondehPlateAClicked, ondehPlateBClicked
    //                pulut: milkIsClicked, bowlAClicked, bowlBClicked

    //level stats
    public static bool initiating = false;
    public static int customersServed = 0;

    //num of dishes possible for this level
    public static int numOfDishes = 2;

    //resetting clicks
    public static bool resetClicks = false; 
    public static bool resetClicksOndeh = false;
    public static bool resetClicksPulut = false;

    //customer generation
    public static Vector3 customerACoordinates = new Vector3(6.19f, 6f, -2f);
    public static Vector3 customerBCoordinates = new Vector3(1.19f, 6f, -2f); 
    public static Vector3 customerCCoordinates = new Vector3(-4.19f, 6f, -2f);
    public static Vector3 addReqCoordinates = new Vector3(-2.1f,1.11f,0.1f);
    
    public Transform uncleObj;
    public Transform ladyObj;
    public Transform boyObj;
    public Transform womanObj;

    public static bool customerOnA = false;
    public static bool customerOnB = false;
    public static bool customerOnC = false;
    public static string dishOnA = "none";
    public static string dishOnB = "none";
    public static string dishOnC = "none";
    public float timeWithoutCustomerOnA = 0;
    public float timeWithoutCustomerOnB = 0;
    public float timeWithoutCustomerOnC = 0;
    public float maxTimeWithoutCustomer = 3f;

    //ondeh
    public static Vector3 plateACoords = new Vector3(4.605f, 3.115f, 3.643f);
    public static Vector3 plateBCoords = new Vector3(2.706f, 3.115f, 3.643f);
    public static Vector3 steamerACoords = new Vector3(6.55f, 3.636f, 2.11f);
    public static Vector3 steamerBCoords = new Vector3(6.55f, 3.636f, 3.774f);
    
    public static Vector3 sugarOnDoughCoords = new Vector3(4.888f, 4.04f, 1.64f);
    public static Vector3 addBoilingOndehCoords = new Vector3(0, 0.154f, 0); //from steamer

    public static Vector3 undercookedOndehCoords = new Vector3(-0.069f, 0.2261f, 0.096f); //from plate
    public static Vector3 cookedOndehCoords = new Vector3(-0.029f, 0.109f, 0); //from plate
    public static Vector3 overcookedOndehCoords = new Vector3(-0.029f, 0.109f, 0); //from plate

    public static Vector3 addCoconutCoords = new Vector3(0.016f, 0.119f, 0); //from cooked & overcooked ondeh
    public static Vector3 addUndercookedCoconutCoords = new Vector3(0,0,0); //from undercooked ondeh

    public static float timeForOndehToCook = 3f;
    public static float timeForOndehToBurn = 5f;
    
    public static bool doughOnSteamerA = false;
    public static bool doughOnSteamerB = false;
    public static bool ondehOnPlateA = false;
    public static bool ondehOnPlateB = false;

    public static bool coconutClicked = false;
    public static bool ondehPlateAClicked = false;
    public static bool ondehPlateBClicked = false;

    public static bool ondehOnACooked = false;
    public static bool ondehOnBCooked = false;
    public static bool coconutOnA = false;
    public static bool coconutOnB = false;

    public static bool destroyOndehA = false;
    public static bool destroyOndehB = false;

    //puluthitam

    public static Vector3 potACoords = new Vector3(-3.219f, 3.663f, 3.69f);
    public static Vector3 potBCoords = new Vector3(-5.12f, 3.663f, 3.69f);
    public static Vector3 bowlACoords = new Vector3(0.69f, 3.461f, 3.732f);
    public static Vector3 bowlBCoords = new Vector3(-1.29f, 3.461f, 3.732f);

    public static Vector3 addRiceCoords = new Vector3(-0.26f, 0.238f, 0.063f); //from pot
    public static Vector3 addPandanCoords = new Vector3(-0.128f, 0.264f, 0.044f); //from pot
    public static Vector3 addSugarCoords = new Vector3(-0.128f, 0.264f, 0.122f); //from pot

    public static Vector3 addPulutCoords = new Vector3(0.052f, 0, 0.108f); //from bowl
    public static Vector3 addMilkCoords = new Vector3(0.042f, 0.044f, -0.086f); //from pulut in bowl

    public static int potAStep = 1;
    public static int potBStep = 1;
    public static float timeForPulutToCook = 3f;
    public static float timeForPulutToBurn = 5f;

    public static bool bowlAOccupied = false;
    public static bool bowlBOccupied = false;

    public static bool bowlACooked = false;
    public static bool bowlBCooked = false;
    public static bool milkAddedOnA = false;
    public static bool milkAddedOnB = false;

    public static bool milkIsClicked = false;
    public static bool bowlAClicked = false;
    public static bool bowlBClicked = false;

    public static bool destroyPulutA = false;
    public static bool destroyPulutB = false;
    


    // Start is called before the first frame update
    void Start()
    {

        initiating = true;

        //stats
        customersServed = 0;

        //customer generation
        customerOnA = false;
        customerOnB = false;
        customerOnC = false;
        dishOnA = "none";
        dishOnB = "none";
        dishOnC = "none";
        timeWithoutCustomerOnA = 0;
        timeWithoutCustomerOnB = 0;
        timeWithoutCustomerOnC = 0;

        //ondeh
        doughOnSteamerA = false;
        doughOnSteamerB = false;
        ondehOnPlateA = false;
        ondehOnPlateB = false;

        coconutClicked = false;
        ondehPlateAClicked = false;
        ondehPlateBClicked = false;

        ondehOnACooked = false;
        ondehOnBCooked = false;
        coconutOnA = false;
        coconutOnB = false;

        destroyOndehA = false;
        destroyOndehB = false;

        //pulut
        bowlAOccupied = false;
        bowlBOccupied = false;

        bowlACooked = false;
        bowlBCooked = false;
        milkAddedOnA = false;
        milkAddedOnB = false;

        milkIsClicked = false;
        bowlAClicked = false;
        bowlBClicked = false;

        destroyPulutA = false;
        destroyPulutB = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (resetClicksOndeh) {
            resetClickingOndeh();
            resetClicksOndeh = false;
        }
        if (resetClicksPulut) {
            resetClickingPulut();
            resetClicksPulut = false;
        }
        if (resetClicks) {
            resetClickingOndeh();
            resetClickingPulut();
            resetClicks = false;
        }
        
        //add time passed without customer at each spot
        if (!customerOnA) {
            timeWithoutCustomerOnA += Time.deltaTime;
        }
        if (!customerOnB) {
            timeWithoutCustomerOnB += Time.deltaTime;
        }
        if (!customerOnC) {
            timeWithoutCustomerOnC += Time.deltaTime;
        }

        //check how long there is no customer in that position
        if (timeWithoutCustomerOnA > maxTimeWithoutCustomer - 0.5f) {
            generateCustomer(customerACoordinates);
            customerOnA = true;
            timeWithoutCustomerOnA = 0;
        }
        if (timeWithoutCustomerOnB > maxTimeWithoutCustomer + 1f) {
            generateCustomer(customerBCoordinates);
            customerOnB = true;
            timeWithoutCustomerOnB = 0;
        }
        if (timeWithoutCustomerOnC > maxTimeWithoutCustomer + 2f) {
            generateCustomer(customerCCoordinates);
            customerOnC = true;
            timeWithoutCustomerOnC = 0;
        }

    }
    
    //select a random customer model to add to counter
    void generateCustomer(Vector3 cusCoord) {
        int cusSelector = Random.Range(1,5);
        if (cusSelector == 1) {
            Instantiate(uncleObj, cusCoord, uncleObj.rotation);
        } else if (cusSelector == 2) {
            Instantiate(ladyObj, cusCoord, ladyObj.rotation);
        } else if (cusSelector == 3) {
            Instantiate(boyObj, cusCoord, boyObj.rotation);
        } else if (cusSelector == 4) {
            Instantiate(womanObj, cusCoord, womanObj.rotation);
        }
    }

    void resetClickingOndeh() {
        coconutClicked = false;
        ondehPlateAClicked = false;
        ondehPlateBClicked = false;
    }

    void resetClickingPulut(){
        milkIsClicked = false;
        bowlAClicked = false;
        bowlBClicked = false;
    }

    
}
