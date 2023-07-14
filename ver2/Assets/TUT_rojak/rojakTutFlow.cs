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
        //Debug.Log("stepcounter: "+stepCounter);

        if (stepCounter != stepTracker) {
            if (stepCounter == 2) {
                instr1.SetActive(false);
                instr2.SetActive(true);
            } else if (stepCounter == 3) {
                instr2.SetActive(false);
                instr3.SetActive(true);
            } else if (stepCounter == 4) {
                instr3.SetActive(false);
                instr4.SetActive(true);
            } else if (stepCounter == 5) {
                instr4.SetActive(false);
                instr5.SetActive(true);
            } else if (stepCounter == 6) { 
                instr5.SetActive(false);
                instr6.SetActive(true);
            
            } else if (stepCounter == 7) {
                instr6.SetActive(false);
                instr7.SetActive(true);
            } else if (stepCounter == 8) { 
                instr7.SetActive(false);
                instr8.SetActive(true);
            } else if (stepCounter == 9) { 
                instr8.SetActive(false);
                instr9.SetActive(true);
            } else if (stepCounter == 10) { 
                instr9.SetActive(false);
                instr10.SetActive(true);
            } else if (stepCounter == 11) { 
                instr10.SetActive(false);
                instr11.SetActive(true);
            } else if (stepCounter == 12) { 
                instr11.SetActive(false);
                instr12.SetActive(true);
            } else if (stepCounter == 13) { 
                instr12.SetActive(false);
                instr13.SetActive(true);
            } else if (stepCounter == 14) { 
                instr13.SetActive(false);
                instr14.SetActive(true);
            } else if (stepCounter == 15) { 
                instr14.SetActive(false);
                instr15.SetActive(true);
            } else if (stepCounter == 16) { 
                instr15.SetActive(false);
                instr16.SetActive(true);
            } else if (stepCounter == 17) { 
                instr16.SetActive(false);
                instr17.SetActive(true);
            }
            stepTracker++;
        }                
    }
}
