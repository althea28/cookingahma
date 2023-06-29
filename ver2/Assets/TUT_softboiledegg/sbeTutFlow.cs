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
                //DELETE INSTR#1
                //ADD INSTR#2
            } else if (stepCounter == 3) {
                //DELETE INSTR#2
                //ADD INSTR#3
            } else if (stepCounter == 4) {
                //DELETE INSTR#3
                //ADD INSTR#4
            } else if (stepCounter == 5) {
                //DELETE INSTR#4
                //ADD INSTR#3
                //....CONTINUE FOR OTHER INSTR.....
            } else if (stepCounter == 15) { //last instr
                //DELETE INSTR#14
                //ADD INSTR#15
            }
            stepTracker++;
        }                
    }
}
