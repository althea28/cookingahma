using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rojakTutFlow : MonoBehaviour
{
    public static int stepCounter = 1;
    private static int stepTracker = 1;

    public static Vector3 boardACoords = new Vector3(-2.47f, 3.06f, 3.77f);
    public static Vector3 boardBCoords = new Vector3(-5.14f, 3.06f, 3.77f);
    public static Vector3 bowlACoords = new Vector3(2.01f, 2.95f, 3.41f);
    public static Vector3 bowlBCoords = new Vector3(-0.06f, 2.95f, 3.41f);

    public static Vector3 addFruitsBoardCoords = new Vector3(0.43f, 0.246f, 0.09f); //from board
    public static Vector3 addCutFruitsBoardCoords = new Vector3(0.43f, 0.135f, 0.09f); //from board
    public static Vector3 addVegeBoardCoords = new Vector3(0.54f, 0.168f, -0.06f); //from board
    public static Vector3 addCutVegeBoardCoords = new Vector3(0.291f, 0.08f, 0.048f); //from board
    public static Vector3 addTofuBoardCoords = new Vector3 (0.45f, 0.12f, 0.12f); //from board
    public static Vector3 addCutTofuBoardCoords = new Vector3 (0.169f, -0.18f, 0.126f); //from board

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
    public GameObject instr16;
    public GameObject instr17;

    public static int stepStart = 1;
    public static int stepClickFruitBox = 2;
    public static int stepClickKnifeA = 3;
    public static int stepPrecutFruit = 4;
    public static int stepMoveFruit = 5;
    public static int stepClickVegeBox = 6;
    public static int stepClickKnifeB = 7;
    public static int stepPrecutVege = 8;
    public static int stepMoveVege = 9;
    public static int stepClickTofuPlate = 10;
    public static int stepClickKnifeC = 11;
    public static int stepPrecutTofu = 12;
    public static int stepMoveTofu = 13;
    public static int stepClickSauce = 14;
    public static int stepAddSauce = 15;
    public static int stepClickRojak = 16;
    public static int stepServeRojak = 17;

    // Start is called before the first frame update
    void Start()
    {
        stepCounter = stepStart;
        stepTracker = stepStart;
        Instantiate(customerObj, customerBCoordinates, customerObj.rotation);

        //ADD INSTR#1

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("stepcounter: "+stepCounter);

        if (stepCounter != stepTracker) {
            Debug.Log("stepcounter: "+stepCounter);
            nextStep();
        }
    }

    void nextStep() {
        if (stepCounter == stepClickFruitBox) {
            instr1.SetActive(false);
            instr2.SetActive(true);
        } else if (stepCounter == stepClickKnifeA) {
            instr2.SetActive(false);
            instr3.SetActive(true);
        } else if (stepCounter == stepPrecutFruit) {
            instr3.SetActive(false);
            instr4.SetActive(true);
        } else if (stepCounter == stepMoveFruit) {
            instr4.SetActive(false);
            instr5.SetActive(true);
        } else if (stepCounter == stepClickVegeBox) { 
            instr5.SetActive(false);
            instr6.SetActive(true);

        } else if (stepCounter == stepClickKnifeB) {
            instr6.SetActive(false);
            instr7.SetActive(true);
        } else if (stepCounter == stepPrecutVege) { 
            instr7.SetActive(false);
            instr8.SetActive(true);
        } else if (stepCounter == stepMoveVege) { 
            instr8.SetActive(false);
            instr9.SetActive(true);
        } else if (stepCounter == stepClickTofuPlate) { 
            instr9.SetActive(false);
            instr10.SetActive(true);
        } else if (stepCounter == stepClickKnifeC) { 
            instr10.SetActive(false);
            instr11.SetActive(true);
        } else if (stepCounter == stepPrecutTofu) { 
            instr11.SetActive(false);
            instr12.SetActive(true);
        } else if (stepCounter == stepMoveTofu) { 
            instr12.SetActive(false);
            instr13.SetActive(true);
        } else if (stepCounter == stepClickSauce) { 
            instr13.SetActive(false);
            instr14.SetActive(true);
        } else if (stepCounter == stepAddSauce) { 
            instr14.SetActive(false);
            instr15.SetActive(true);
        } else if (stepCounter == stepClickRojak) { 
            instr15.SetActive(false);
            instr16.SetActive(true);
        } else if (stepCounter == stepServeRojak) { 
            instr16.SetActive(false);
            instr17.SetActive(true);
        }
        stepTracker++;
    }
}
