using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ckTutFlow : MonoBehaviour
{
    public static int stepCounter = 1;
    private static int stepTracker = 1;

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
            }
            stepTracker++;
        }                
    }
}
