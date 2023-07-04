using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow2 : MonoBehaviour
{
    //level stats
    public static int customersServed = 0;

    //num of dishes possible for this level
    public static int numOfDishes = 1;

    //resetting clicks
    public static bool resetClicks = false; 
    public static bool resetClicksChweeKueh = false;

    //customer generation
    public static Vector3 customerACoordinates = new Vector3(6.19f, 6f, -2f);
    public static Vector3 customerBCoordinates = new Vector3(1.19f, 6f, -2f); 
    public static Vector3 customerCCoordinates = new Vector3(-4.19f, 6f, -2f);
    public static Vector3 addReqCoordinates = new Vector3(-2.1f,1.11f,0.1f);
    
    public Transform uncleObj;
    public Transform ladyObj;
    public Transform boyObj;
    public Transform womanObj;

    public static string customerOnA = "n";
    public static string customerOnB = "n";
    public static string customerOnC = "n";
    public static string dishOnA = "none";
    public static string dishOnB = "none";
    public static string dishOnC = "none";
    public float timeWithoutCustomerOnA = 0;
    public float timeWithoutCustomerOnB = 0;
    public float timeWithoutCustomerOnC = 0;
    public float maxTimeWithoutCustomer = 3f;

    //chwee kueh
    public static Vector3 steamerACoords = new Vector3(4.204f, 3.493f, 1.574f);
    public static Vector3 steamerBCoords = new Vector3(4.204f, 3.493f, 3.61f);
    public static Vector3 plateACoords = new Vector3(1.87f, 3.148f, 2.53f);
    public static Vector3 plateBCoords = new Vector3(1.87f, 3.148f, 3.96f);

    public static Vector3 addUndercookedCKCoords = new Vector3(0,0, -0.043f); //from plate coords
    public static Vector3 addCookedCKCoords = new Vector3(0.03f, 0.072f, 0.02f); //from plate coords
    public static Vector3 addOvercookedCKCoords = new Vector3(0.03f, 0.072f, 0.02f); //from plate coords

    public static Vector3 addUndercookedCP = new Vector3(-0.757f, -0.003f, 0.327f); //from undercooked CK
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

    public static string destroySteamA = "n";
    public static string destroySteamB = "n";

    public static string trashA = "n";
    public static string trashB = "n";

    //LEVEL INITIATE
    public static bool initiating = false;

    // Start is called before the first frame update
    void Start()
    {
        initiating = true;

        customerOnA = "n";
        customerOnB = "n";
        customerOnC = "n";
        dishOnA = "none";
        dishOnB = "none";
        dishOnC = "none";

        destroySteamA = "n";
        destroySteamB = "n";

        timeWithoutCustomerOnA = 0;
        timeWithoutCustomerOnB = 0;
        timeWithoutCustomerOnC = 0;

        trashA = "n";
        trashB = "n";

        resetClicking();

    }

    // Update is called once per frame
    void Update()
    {

        if (resetClicks) {
            resetClicking();
        } else if (resetClicksChweeKueh) {
            resetClickingChweeKueh();
        }

        //add time passed without customer at each spot
        if (customerOnA == "n") {
            timeWithoutCustomerOnA += Time.deltaTime;
        }
        if (customerOnB == "n") {
            timeWithoutCustomerOnB += Time.deltaTime;
        }
        if (customerOnC == "n") {
            timeWithoutCustomerOnC += Time.deltaTime;
        }

        //check how long there is no customer in that position
        if (timeWithoutCustomerOnA > maxTimeWithoutCustomer - 0.5f) {
            generateCustomer(customerACoordinates);
            customerOnA = "y";
            timeWithoutCustomerOnA = 0;
        }
        if (timeWithoutCustomerOnB > maxTimeWithoutCustomer + 1f) {
            generateCustomer(customerBCoordinates);
            customerOnB = "y";
            timeWithoutCustomerOnB = 0;
        }
        if (timeWithoutCustomerOnC > maxTimeWithoutCustomer + 2f) {
            generateCustomer(customerCCoordinates);
            customerOnC = "y";
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
    
    public void resetClicking() {
        resetClickingChweeKueh();

        resetClicks = false;
    }

    public void resetClickingChweeKueh() {
        plateAClicked = false;
        plateBClicked = false;
        chaiPohClicked = false;

        resetClicksChweeKueh = false;
    }

}
