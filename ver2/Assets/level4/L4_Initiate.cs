using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4_Initiate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gameflow2.initiating) {
           gameflow2.numOfDishes = 1;
           gameflow2.initiating = false;
       }
    }
}
