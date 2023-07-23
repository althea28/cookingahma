using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulutTutFlow : MonoBehaviour
{
    public static int stepCounter = 1;
    private static int stepTracker = 1;

    public static Vector3 customerBCoordinates = new Vector3(1.19f, 6f, -2f);     
    public static Vector3 addReqCoordinates = new Vector3(-2.1f,1.11f,0.1f);

    public static Vector3 potACoords = new Vector3(-3.219f, 3.663f, 3.69f);
    public static Vector3 potBCoords = new Vector3(-5.12f, 3.663f, 3.69f);
    public static Vector3 bowlACoords = new Vector3(0.69f, 3.461f, 3.732f);
    public static Vector3 bowlBCoords = new Vector3(-1.29f, 3.461f, 3.732f);

    public static Vector3 addRiceCoords = new Vector3(-0.26f, 0.238f, 0.063f); //from pot
    public static Vector3 addPandanCoords = new Vector3(-0.128f, 0.264f, 0.044f); //from pot
    public static Vector3 addSugarCoords = new Vector3(-0.128f, 0.264f, 0.122f); //from pot

    public static Vector3 addPulutCoords = new Vector3(0.052f, 0, 0.108f); //from bowl
    public static Vector3 addMilkCoords = new Vector3(0.042f, 0.044f, -0.086f); //from pulut in bowl

    public Transform customerObj;

    public GameObject instr1;
    public GameObject instr2;
    public GameObject instr3;
    public GameObject instr4;
    public GameObject instr5;
    public GameObject instr6;
    public GameObject instr7;
    public GameObject instr8;
    public GameObject instr9;
    public GameObject instr10;
    public GameObject instr11;
    public GameObject instr12;
    public GameObject instr13;
    public GameObject instr14;
    public GameObject instr15;
    public GameObject instr16;
    public GameObject instr17;
    public GameObject instr18;
    public GameObject instr19;
    public GameObject instr20;
    public GameObject instr21;

    public static int stepStart = 1;
    public static int stepAddRiceA = 2;
    public static int stepAddRiceB = 3;
    public static int stepAddPandanA = 4;
    public static int stepAddPandanB = 5;
    public static int stepAddSugarA = 6;
    public static int stepAddSugarB = 7;
    public static int stepMoveUndercooked = 8;
    public static int stepClickUndercooked = 9;
    public static int stepTrashUndercooked = 10;
    public static int stepAddRiceC = 11;
    public static int stepAddPandanC = 12;
    public static int stepAddSugarC = 13;
    public static int stepMoveCooked = 14;
    public static int stepClickMilk = 15;
    public static int stepAddMilk = 16;
    public static int stepClickCooked = 17;
    public static int stepServeCustomer = 18;
    public static int stepMoveBurnt = 19;
    public static int stepClickBurnt = 20;
    public static int stepTrashBurnt = 21;

    // Start is called before the first frame update
    void Start()
    {
        stepCounter = stepStart;
        stepTracker = stepStart;
        Instantiate(customerObj, customerBCoordinates, customerObj.rotation);

    }

    // Update is called once per frame
    void Update()
    {

        if (stepCounter != stepTracker) {
            Debug.Log("step: "+stepCounter);
            nextStep();
        }
    }

    void nextStep() {
        if (stepCounter == stepAddRiceA) {
            instr1.SetActive(false);
            instr2.SetActive(true);
        } else if (stepCounter == stepAddRiceB) {
            instr2.SetActive(false);
            instr3.SetActive(true);
        } else if (stepCounter == stepAddPandanA) {
            instr3.SetActive(false);
            instr4.SetActive(true);
        } else if (stepCounter == stepAddPandanB) {
            instr4.SetActive(false);
            instr5.SetActive(true);
        } else if (stepCounter == stepAddSugarA) { 
            instr5.SetActive(false);
            instr6.SetActive(true);

        } else if (stepCounter == stepAddSugarB) {
            instr6.SetActive(false);
            instr7.SetActive(true);
        } else if (stepCounter == stepMoveUndercooked) { 
            instr7.SetActive(false);
            instr8.SetActive(true);
        } else if (stepCounter == stepClickUndercooked) { 
            instr8.SetActive(false);
            instr9.SetActive(true);
        } else if (stepCounter == stepTrashUndercooked) { 
            instr9.SetActive(false);
            instr10.SetActive(true);
        } else if (stepCounter == stepAddRiceC) { 
            instr10.SetActive(false);
            instr11.SetActive(true);
        } else if (stepCounter == stepAddPandanC) { 
            instr11.SetActive(false);
            instr12.SetActive(true);
        } else if (stepCounter == stepAddSugarC) { 
            instr12.SetActive(false);
            instr13.SetActive(true);
        } else if (stepCounter == stepMoveCooked) { 
            instr13.SetActive(false);
            instr14.SetActive(true);
        } else if (stepCounter == stepClickMilk) { 
            instr14.SetActive(false);
            instr15.SetActive(true);
        } else if (stepCounter == stepAddMilk) { 
            instr15.SetActive(false);
            instr16.SetActive(true);
        } else if (stepCounter == stepClickCooked) { 
            instr16.SetActive(false);
            instr17.SetActive(true);
        } else if (stepCounter == stepServeCustomer) { 
            instr17.SetActive(false);
            instr18.SetActive(true);
        } else if (stepCounter == stepMoveBurnt) { 
            instr18.SetActive(false);
            instr19.SetActive(true);
        } else if (stepCounter == stepClickBurnt) { 
            instr19.SetActive(false);
            instr20.SetActive(true);
        } else if (stepCounter == stepTrashBurnt) { 
            instr20.SetActive(false);
            instr21.SetActive(true);
        }
        stepTracker++;
    }

}
