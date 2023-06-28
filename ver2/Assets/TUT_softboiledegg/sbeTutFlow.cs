using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sbeTutFlow : MonoBehaviour
{
    /*
    steps:    
    1: click on egg carton -> add egg on steamer A ;; instr click eggcarton again
    2: click on egg carton -> add egg on steamer B ;; instr wait for eggs to cook 
    3: click on egg A (undercooked) -> transf undercooked egg to plate A ;; 
        instr says its undercooked, tell player to click on undercooked egg
    4: click on undercooked egg ;; instr click on trash bin
    5: click on bin ;; instr click on eggcarton to add new eggC
    6: click on egg carton again. eggB starts steaming -> instr click on egg B (cooked)
    7: click on egg B. destroy cookedsteamB ;; instr to click on soya sauce bottle
    8: click on soya sauce bottle. ;; instr click on eggB
    9: click on eggB. eggC starts steaming ;; instr click on egg to serve
    10: click on eggC. ;; instr click on customer to serve
    11: click on customer. customer destroyed. eggC starts having overcooked steam;; instr click on eggC
    12: click on eggC. overcooked egg appears ;; instr rmb not to leave it too long. ready to play.
    */

    public static int stepCounter = 1;

    public static Vector3 steamerACoords = new Vector3(6.044f, 3.385f, 3.55f);
    public static Vector3 steamerBCoords = new Vector3(5.11f, 3.385f, 3.55f); //5.047
    public static Vector3 plateACoords = new Vector3(3.36f, 3.01f, 1.916f);
    public static Vector3 plateBCoords = new Vector3(3.36f, 3.01f, 3.8f);

    public static Vector3 addUndercookedEggsCoords = new Vector3(-0.03f, -0.02f, 0.07f);
    public static Vector3 addCookedEggsCoords = new Vector3(-0.03f, -0.02f, 0.07f);
    public static Vector3 addOvercookedEggsCoords = new Vector3(0.05f, -0.02f, -0.04f);
    public static Vector3 addSoyaSauceCoords = new Vector3(-0.021f, 0.139f, -0.019f); //from egg, not plate
    public static Vector3 addOCSoyaSauceCoords = new Vector3(-0.11f, 0.15f, 0.19f);


    public static float timeForEggToCook = 3f;
    public static float timeForEggToBurn = 5f;


    // Start is called before the first frame update
    void Start()
    {
        stepCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
