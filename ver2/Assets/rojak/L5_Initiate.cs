using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5_Initiate : MonoBehaviour
{
    private int numOfDishes = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gameflow2.initiating) {
           gameflow2.numOfDishes = numOfDishes;

           gameflow2.steamerACoords = new Vector3(6.58f, 3.493f, 1.574f);
           gameflow2.steamerBCoords = new Vector3(6.58f, 3.493f, 3.61f);
           gameflow2.plateACoords = new Vector3(4.246f, 3.148f, 2.53f);
           gameflow2.plateBCoords = new Vector3(4.246f, 3.148f, 3.96f);
           gameflow2.cpSpoonCoords = new Vector3(1.194f, 3.784f, 1.07f);

           gameflow2.initiating = false;
       }
    }
}
