using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{

    //sticky clicks: 
    //     kayatoast: placeKaya, placeButter, toastAIsClicked, toastBIsClicked
    //     eggs: plateAClicked, plateBClicked, soyaSauceClicked

    public static int customersServed = 0;
    public static int numOfDishes = 2;

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

    public static string toastOnGrillA = "n";
    public static string toastOnGrillB = "n";
    public static string toastOnBoardA = "n";
    public static string toastOnBoardB = "n";
    
    public static string placeKaya = "n"; 
    public static string placeButter = "n";

    public static string destroySteamA = "n";
    public static string destroySteamB = "n";

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

    public static string toastAIsClicked = "n";
    public static string toastBIsClicked = "n";
    public static string trashA = "n";
    public static string trashB = "n";

    public static int count = 0;

    //LEVEL INITIATE
    public static bool initiating = false;

    public static int sceneCounter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        initiating = true; //INITIATES LEVEL DETAILS

        toastOnGrillA = "n";
        toastOnGrillB = "n";
        toastOnBoardA = "n";
        toastOnBoardB = "n";

        destroySteamA = "n";
        destroySteamB = "n";

        customerOnA = "n";
        customerOnB = "n";
        customerOnC = "n";
        dishOnA = "none";
        dishOnB = "none";
        dishOnC = "none";
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
        } else if (resetClicksToast) {
            resetClickingToast();
        } else if (resetClicksEggs) {
            resetClickingEggs();
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

    public void resetClicking() {
        resetClickingToast();
        resetClickingEggs();

        resetClicks = false;
    }

    public void resetClickingToast() {
        placeKaya = "n"; 
        placeButter = "n";
        toastAIsClicked = "n";
        toastBIsClicked = "n";

        resetClicksToast = false;
    }

 
    public void resetClickingEggs() {
        plateAClicked = false;
        plateBClicked = false;
        soyaSauceClicked = false;

        resetClicksEggs = false;
    }








 
}
