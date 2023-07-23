using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sbeTutFlow : MonoBehaviour
{
    public static int stepCounter = 1;
    private static int stepTracker = 1;

    public static Vector3 steamerACoords = new Vector3(6.044f, 3.385f, 3.55f);
    public static Vector3 steamerBCoords = new Vector3(5.11f, 3.385f, 3.55f); //5.047
    public static Vector3 plateACoords = new Vector3(3.36f, 3.01f, 1.916f);
    public static Vector3 plateBCoords = new Vector3(3.36f, 3.01f, 3.8f);

    public static Vector3 addUndercookedEggsCoords = new Vector3(-0.03f, -0.02f, 0.07f);
    public static Vector3 addCookedEggsCoords = new Vector3(-0.03f, -0.02f, 0.07f);
    public static Vector3 addOvercookedEggsCoords = new Vector3(0.05f, -0.02f, -0.04f);
    public static Vector3 addSoyaSauceCoords = new Vector3(-0.021f, 0.139f, -0.019f); //from egg, not plate
    public static Vector3 addOCSoyaSauceCoords = new Vector3(-0.11f, 0.15f, 0.19f);

    public static Vector3 customerBCoordinates = new Vector3(1.19f, 6f, -2f);     
    public static Vector3 addReqCoordinates = new Vector3(-2.1f,1.11f,0.1f);
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

    public static int stepStart = 1;
    public static int stepAddEggA = 2;
    public static int stepAddEggB = 3;
    public static int stepMoveUndercooked = 4;
    public static int stepClickUndercooked = 5;
    public static int stepTrashUndercooked = 6;
    public static int stepAddEggC = 7;
    public static int stepMoveCooked = 8;
    public static int stepClickSoya = 9;
    public static int stepAddSoya = 10;
    public static int stepClickCooked = 11;
    public static int stepServeCustomer = 12;
    public static int stepMoveBurnt = 13;
    public static int stepClickBurnt = 14;
    public static int stepTrashBurnt = 15;


    // Start is called before the first frame update
    void Start()
    {
        stepCounter = 1;
        stepTracker = 1;
        Instantiate(customerObj, customerBCoordinates, customerObj.rotation);

        //ADD INSTR#1

    }

    // Update is called once per frame
    void Update()
    {

        if (stepCounter != stepTracker) {

            Debug.Log("stepcounter: "+stepCounter);
            nextStep();
        }
    }
    void nextStep() {

        if (stepCounter == stepAddEggA) {
            instr1.SetActive(false);
            instr2.SetActive(true);
        } else if (stepCounter == stepAddEggB) {
            instr2.SetActive(false);
            instr3.SetActive(true);
        } else if (stepCounter == stepMoveUndercooked) {
            instr3.SetActive(false);
            instr4.SetActive(true);
        } else if (stepCounter == stepClickUndercooked) {
            instr4.SetActive(false);
            instr5.SetActive(true);
        } else if (stepCounter == stepTrashUndercooked) { 
            instr5.SetActive(false);
            instr6.SetActive(true);

        } else if (stepCounter == stepAddEggC) {
            instr6.SetActive(false);
            instr7.SetActive(true);
        } else if (stepCounter == stepMoveCooked) { 
            instr7.SetActive(false);
            instr8.SetActive(true);
        } else if (stepCounter == stepClickSoya) { 
            instr8.SetActive(false);
            instr9.SetActive(true);
        } else if (stepCounter == stepAddSoya) { 
            instr9.SetActive(false);
            instr10.SetActive(true);
        } else if (stepCounter == stepClickCooked) { 
            instr10.SetActive(false);
            instr11.SetActive(true);
        } else if (stepCounter == stepServeCustomer) { 
            instr11.SetActive(false);
            instr12.SetActive(true);
        } else if (stepCounter == stepMoveBurnt) { 
            instr12.SetActive(false);
            instr13.SetActive(true);
        } else if (stepCounter == stepClickBurnt) { 
            instr13.SetActive(false);
            instr14.SetActive(true);
        } else if (stepCounter == stepTrashBurnt) { 
            instr14.SetActive(false);
            instr15.SetActive(true);
        }
        stepTracker++;
    }                
}
