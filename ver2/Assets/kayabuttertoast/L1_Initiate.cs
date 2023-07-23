using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1_Initiate : MonoBehaviour
{
    private int numOfDishes = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gameflow.initiating) {
           gameflow.numOfDishes = numOfDishes;
           gameflow.initiating = false;
       }
    }
}
