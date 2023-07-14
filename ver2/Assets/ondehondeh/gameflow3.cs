using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow3 : MonoBehaviour
{
    //sticky clicks:  ondeh: coconutClicked, ondehPlateAClicked, ondehPlateBClicked

    //level stats
    public static int customersServed = 0;

    //num of dishes possible for this level
    public static int numOfDishes = 1;

    //resetting clicks
    //public static bool resetClicks = false; 
    public static bool resetClicksOndeh = false;
    //public static bool resetClicksRojak = false;

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
    public static Vector3 plateACoords = new Vector3(3.205f, 3.115f, 3.643f);
    public static Vector3 plateBCoords = new Vector3(1.306f, 3.115f, 3.643f);
    public static Vector3 steamerACoords = new Vector3(5.15f, 3.636f, 2.11f);
    public static Vector3 steamerBCoords = new Vector3(5.15f, 3.636f, 3.774f);
    
    public static Vector3 sugarOnDoughCoords = new Vector3(3.512f, 4.04f, 1.64f);
    public static Vector3 addBoilingOndehCoords = new Vector3(0, 0.154f, 0);

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


    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resetClicksOndeh) {
            resetClickingOndeh();
            resetClicksOndeh = false;
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

    
}
