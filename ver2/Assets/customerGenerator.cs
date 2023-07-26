using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerGenerator : MonoBehaviour
{
    public static Vector3 customerACoordinates = new Vector3(6.19f, 6f, -2f);
    public static Vector3 customerBCoordinates = new Vector3(1.19f, 6f, -2f); 
    public static Vector3 customerCCoordinates = new Vector3(-4.19f, 6f, -2f);
    public static Vector3 addReqCoordinates = new Vector3(-2.1f,1.11f,0.1f);
    
    private int numOfCustomerModels = 4;
    private int uncleModel = 1;
    private int ladyModel = 2;
    private int boyModel = 3;
    private int womanModel = 4;
    
    public Transform uncleObj;
    public Transform ladyObj;
    public Transform boyObj;
    public Transform womanObj;

    public static bool customerOnA = false;
    public static bool customerOnB = false;
    public static bool customerOnC = false;
    /*public static string dishOnA = "none";
    public static string dishOnB = "none";
    public static string dishOnC = "none";*/
    private float timeWithoutCustomerOnA = 0;
    private float timeWithoutCustomerOnB = 0;
    private float timeWithoutCustomerOnC = 0;
    private float maxTimeWithoutCustomerA = 2.5f;
    private float maxTimeWithoutCustomerB = 4f;
    private float maxTimeWithoutCustomerC = 4.5f;



    // Start is called before the first frame update
    void Start()
    {
        customerOnA = false;
        customerOnB = false;
        customerOnC = false;
        /*dishOnA = "none";
        dishOnB = "none";
        dishOnC = "none";*/
        timeWithoutCustomerOnA = 0;
        timeWithoutCustomerOnB = 0;
        timeWithoutCustomerOnC = 0;
    }

    // Update is called once per frame
    void Update()
    {
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
        if (timeWithoutCustomerOnA > maxTimeWithoutCustomerA) {
            generateCustomer(customerACoordinates);
            customerOnA = true;
            timeWithoutCustomerOnA = 0;
        }
        if (timeWithoutCustomerOnB > maxTimeWithoutCustomerB) {
            generateCustomer(customerBCoordinates);
            customerOnB = true;
            timeWithoutCustomerOnB = 0;
        }
        if (timeWithoutCustomerOnC > maxTimeWithoutCustomerC) {
            generateCustomer(customerCCoordinates);
            customerOnC = true;
            timeWithoutCustomerOnC = 0;
        }

    }

    void generateCustomer(Vector3 cusCoord) {
        int cusSelector = Random.Range(1, numOfCustomerModels + 1);
        if (cusSelector == uncleModel) {
            Instantiate(uncleObj, cusCoord, uncleObj.rotation);
        } else if (cusSelector == ladyModel) {
            Instantiate(ladyObj, cusCoord, ladyObj.rotation);
        } else if (cusSelector == boyModel) {
            Instantiate(boyObj, cusCoord, boyObj.rotation);
        } else if (cusSelector == womanModel) {
            Instantiate(womanObj, cusCoord, womanObj.rotation);
        }
    }

}

