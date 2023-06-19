using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{

    public static int customersServed = 0;

    public static Vector3 boardACoordinates = new Vector3(2.9f,3.08f,3.37f);
    public static Vector3 boardBCoordinates = new Vector3(0.52f,3.08f,3.37f);
    public static Vector3 grillACoordinates = new Vector3(-2.15f, 3.072f, 3.3f);
    public static Vector3 grillBCoordinates = new Vector3(-3.94f, 3.072f, 3.3f);
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

    
    /*==========
    public static string isCustomerClicked = "n";
    public static string isToastClicked = "n";
    public static string destroyToast = "n";
    public static string destroyKaya = "n";
    public static string destroyButter = "n";
    */ //===========

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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




 
}
