using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4_Initiate : MonoBehaviour
{
    private int numOfDishes = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gameflow2.initiating) {
           gameflow2.numOfDishes = numOfDishes;

           gameflow2.steamerACoords = new Vector3(4.204f, 3.493f, 1.574f);
           gameflow2.steamerBCoords = new Vector3(4.204f, 3.493f, 3.61f);
           gameflow2.plateACoords = new Vector3(1.87f, 3.148f, 2.53f);
           gameflow2.plateBCoords = new Vector3(1.87f, 3.148f, 3.96f);
           gameflow2.cpSpoonCoords = new Vector3(-1.05f, 3.784f, 1.33f);

           gameflow2.initiating = false;
       }
    }
}
