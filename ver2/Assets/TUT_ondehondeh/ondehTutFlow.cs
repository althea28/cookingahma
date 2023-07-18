using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ondehTutFlow : MonoBehaviour
{
    public static int stepCounter = 1;
    private static int stepTracker = 1;

    public static Vector3 plateACoords = new Vector3(3.205f, 3.115f, 3.643f);
    public static Vector3 plateBCoords = new Vector3(1.306f, 3.115f, 3.643f);
    public static Vector3 steamerACoords = new Vector3(5.15f, 3.636f, 2.11f);
    public static Vector3 steamerBCoords = new Vector3(5.15f, 3.636f, 3.774f);

    public static Vector3 undercookedOndehCoords = new Vector3(-0.069f, 0.2261f, 0.096f); //from plate
    public static Vector3 cookedOndehCoords = new Vector3(-0.029f, 0.109f, 0); //from plate
    public static Vector3 overcookedOndehCoords = new Vector3(-0.029f, 0.109f, 0); //from plate

    public static Vector3 sugarOnDoughCoords = new Vector3(3.512f, 4.04f, 1.64f);
    public static Vector3 addBoilingOndehCoords = new Vector3(0, 0.154f, 0);
    public static Vector3 addCoconutCoords = new Vector3(0.016f, 0.119f, 0);

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
    public GameObject instr18;

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
        Debug.Log("stepcounter: "+stepCounter);

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
            } else if (stepCounter == 18) { 
                instr17.SetActive(false);
                instr18.SetActive(true);
            }
            stepTracker++;
        }                
    }
}
