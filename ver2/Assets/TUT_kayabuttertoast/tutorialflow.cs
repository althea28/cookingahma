using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialflow : MonoBehaviour
{
    public static Vector3 boardACoordinates = new Vector3(2.9f,3.08f,3.37f);
    public static Vector3 boardBCoordinates = new Vector3(0.52f,3.08f,3.37f);
    public static Vector3 grillACoordinates = new Vector3(-2.15f, 3.072f, 3.3f);
    public static Vector3 grillBCoordinates = new Vector3(-3.94f, 3.072f, 3.3f);
    public static Vector3 addKayaCoordinates = new Vector3(0.01f, 0.182f, 0.032f);
    public static Vector3 addButterCoordinates = new Vector3(0.005f, 0.247f, 0.129f);

    public static string moveToGrill = "n";
    public static string addedToastB = "n";
    public static string addedKaya = "n";
    public static string addedButter = "n";

    public static string kayaClicked = "n";
    public static string butterClicked = "n";
    public static string toastToServe = "n";

    public static string destroySteamA = "n";
    public static string destroyKaya = "n";
    public static string destroyButter = "n";
    public static string destroyToast = "n";
    public static string destroyReq = "n";

    public Transform customerObj;
    public static Vector3 customerBCoordinates = new Vector3(1.19f, 6f, -2f);
    public static Vector3 addReqCoordinates = new Vector3(-2.1f,1.11f,0.1f);
    
    public static float timeToCook = 3f;
    public static string changeInnerA = "n";
    public static string changeInnerB = "n";

    // Start is called before the first frame update
    void Start()
    {
        moveToGrill = "n";
        addedToastB = "n";
        addedKaya = "n";
        addedButter = "n";

        kayaClicked = "n";
        butterClicked = "n";
        toastToServe = "n";

        destroySteamA = "n";
        destroyKaya = "n";
        destroyButter = "n";
        destroyToast = "n";
        destroyReq = "n";

        changeInnerA = "n";
        changeInnerB = "n";


        Instantiate(customerObj, customerBCoordinates, customerObj.rotation);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
