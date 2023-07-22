using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7_Initiate : MonoBehaviour
{
    /*public static Vector3 plateACoords = new Vector3(3.205f, 3.115f, 3.643f);
    public static Vector3 plateBCoords = new Vector3(1.306f, 3.115f, 3.643f);
    public static Vector3 steamerACoords = new Vector3(5.15f, 3.636f, 2.11f);
    public static Vector3 steamerBCoords = new Vector3(5.15f, 3.636f, 3.774f);
    
    public static Vector3 sugarOnDoughCoords = new Vector3(3.512f, 4.04f, 1.64f);

    public static Vector3 spoonDownCoords = new Vector3(1.055f, 4.131f, 1.211f);*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameflow3.initiating) {
            gameflow3.initiating = false;

            gameflow3.numOfDishes = 1;

            /*gameflow3.plateACoords = new Vector3(3.205f, 3.115f, 3.643f);
            gameflow3.plateBCoords = new Vector3(1.306f, 3.115f, 3.643f);
            gameflow3.steamerACoords = new Vector3(5.15f, 3.636f, 2.11f);
            gameflow3.steamerBCoords = new Vector3(5.15f, 3.636f, 3.774f);
    
            gameflow3.sugarOnDoughCoords = new Vector3(3.512f, 4.04f, 1.64f);
            
            coconutspoon.downCoords = new Vector3(1.055f, 4.131f, 1.211f);*/
        }
        
    }
}
