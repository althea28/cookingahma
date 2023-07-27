using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** dishTwo class is attached to GAMEMASTER in levels 2, 3, 5, 6, 8 and 9 
 * sets the number of possible dishes that can be served in every level to be 2
*/

public class dishTwo : MonoBehaviour
{
    private int numOfDishes = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if ((gameflow.initiating) || (gameflow2.initiating) ||(gameflow3.initiating)) {
            
            customerGenerator.numOfDishes = numOfDishes;
            
            gameflow.initiating = false;
            gameflow2.initiating = false;
            gameflow3.initiating = false;
        } 
    }
}
