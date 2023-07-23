using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7_Initiate : MonoBehaviour
{
    private int numOfDishes = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameflow3.initiating) {
            gameflow3.initiating = false;

            gameflow3.numOfDishes = numOfDishes;
        }
        
    }
}
