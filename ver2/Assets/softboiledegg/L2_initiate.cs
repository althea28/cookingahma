using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_initiate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gameflow.initiating) {
           gameflow.numOfDishes = 2;
           gameflow.initiating = false;
       }
    }
}
